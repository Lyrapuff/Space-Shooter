using SpaceShooter.Menu.UI;
using UnityEngine;

namespace SpaceShooter.Game.UI
{
    public class PauseButton : MonoBehaviour
    {
        [SerializeField] private SwitchGroup _pauseUI;
        
        public void Pause()
        {
            Time.timeScale = 0f;
            _pauseUI.Switch();
        }

        public void Unpause()
        {
            Time.timeScale = 1f;
            _pauseUI.Switch();
        }
    }
}