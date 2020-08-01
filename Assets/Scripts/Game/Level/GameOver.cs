using SpaceShooter.Common.Audio;
using SpaceShooter.Menu.UI;
using SpaceShooter.Game.Bodies;
using UnityEngine;

namespace SpaceShooter.Game.Level
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private Health _playerHealth;
        [SerializeField] private SwitchGroup _gameOverUI;
        [SerializeField] private Sound _sound;

        private void Awake()
        {
            _playerHealth.OnDied += HandleDied;
        }

        private void HandleDied()
        {
            AudioPlayer.Instance.PlaySoundOneShot(_sound);
            _gameOverUI.Switch();
            Time.timeScale = 0f;
        }
    }
}