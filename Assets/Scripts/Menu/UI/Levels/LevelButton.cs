using Game;
using SpaceShooter.Game.Level;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceShooter.Menu.UI.Levels
{
    public class LevelButton : MonoBehaviour
    {
        public LevelObject Level => _level;
        
        [SerializeField] private LevelObject _level;

        private void Awake()
        {
            _level.LoadData();
        }

        public void Select()
        {
            if (_level.LevelState != LevelState.Locked)
            {
                GameConfiguration.SelectedLevel = _level;
                SceneManager.LoadScene(1);
            }
        }
    }
}