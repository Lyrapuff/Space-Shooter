using SpaceShooter.Menu.UI;
using SpaceShooter.Game.Bodies;
using UnityEngine;

namespace SpaceShooter.Game.Level
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private Health _playerHealth;
        [SerializeField] private SwitchGroup _gameOverUI;

        private void Awake()
        {
            _playerHealth.OnDied += HandleDied;
        }

        private void HandleDied()
        {
            _gameOverUI.Switch();
            Time.timeScale = 0f;
        }
    }
}