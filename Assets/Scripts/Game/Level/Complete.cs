using Game;
using SpaceShooter.Common.Audio;
using SpaceShooter.Menu.UI;
using UnityEngine;

namespace SpaceShooter.Game.Level
{
    [RequireComponent(typeof(LevelProgress))]
    public class Complete : MonoBehaviour
    {
        [SerializeField] private SwitchGroup _completeUI;
        [SerializeField] private Sound _sound;
        
        private LevelProgress _levelProgress;

        private void Awake()
        {
            _levelProgress = GetComponent<LevelProgress>();
        }

        private void OnEnable()
        {
            _levelProgress.OnUpdated += HandleUpdated;
        }

        private void OnDisable()
        {
            _levelProgress.OnUpdated -= HandleUpdated;
        }
        
        private void HandleUpdated()
        {
            if (_levelProgress.Killed >= _levelProgress.KillsNeed)
            {
                if (Time.timeScale < 1f)
                {
                    return;
                }
                
                LevelObject level = GameConfiguration.SelectedLevel;
                level.LevelState = LevelState.Completed;
                level.Commit();

                string key = "lastCompletedLevel";
                int number = 0;
                
                if (PlayerPrefs.HasKey(key))
                {
                    number = PlayerPrefs.GetInt(key);
                }

                if (level.Number > number)
                {
                    PlayerPrefs.SetInt(key, level.Number);
                }

                AudioPlayer.Instance.PlaySoundOneShot(_sound);
                
                _completeUI.Switch();
                Time.timeScale = 0f;
            }
        }
    }
}