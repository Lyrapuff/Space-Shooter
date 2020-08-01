using UnityEngine;

namespace SpaceShooter.Game.Level
{
    [CreateAssetMenu(fileName = "New level", menuName = "Space Shooter/Level", order = 0)]
    public class LevelObject : ScriptableObject
    {
        public int Number => _number;
        public int KillsNeed => _killsNeed;
        public LevelState LevelState { get; set; }

        [SerializeField] private int _number;
        [SerializeField] private int _killsNeed;
        [SerializeField] private LevelState _defaultLevelState;

        public void LoadData()
        {
            string levelKey = $"level{_number}.state";
            
            if (PlayerPrefs.HasKey(levelKey))
            {
                LevelState = (LevelState) PlayerPrefs.GetInt(levelKey);
            }
            else
            {
                LevelState = _defaultLevelState;
                Commit();
            }

            string lastCompletedKey = "lastCompletedLevel";
            
            if (LevelState == LevelState.Locked && PlayerPrefs.HasKey(lastCompletedKey))
            {
                int number = PlayerPrefs.GetInt(lastCompletedKey);

                if (number + 1 == _number)
                {
                    LevelState = LevelState.Unlocked;
                    Commit();
                }
            }
        }

        public void Commit()
        {
            PlayerPrefs.SetInt($"level{_number}.state", (int)LevelState);
        }
    }
    
    public enum LevelState
    {
        Locked,
        Unlocked,
        Completed
    }
}