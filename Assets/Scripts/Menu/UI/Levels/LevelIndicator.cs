using SpaceShooter.Game.Level;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceShooter.Menu.UI.Levels
{
    [RequireComponent(typeof(Image))]
    public class LevelIndicator : MonoBehaviour
    {
        [SerializeField] private LevelButton _levelButton;
        [SerializeField] private Color _lockedColor;
        [SerializeField] private Color _unlockedColor;
        [SerializeField] private Color _completeedColor;

        private void Start()
        {
            Image image = GetComponent<Image>();
            
            switch (_levelButton.Level.LevelState)
            {
                case LevelState.Locked:
                    image.color = _lockedColor;
                    break;
                case LevelState.Unlocked:
                    image.color = _unlockedColor;
                    break;
                case LevelState.Completed:
                    image.color = _completeedColor;
                    break;
            }
        }
    }
}