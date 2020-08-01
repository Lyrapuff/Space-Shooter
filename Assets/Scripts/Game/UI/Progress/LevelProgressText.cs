using SpaceShooter.Game.Level;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceShooter.Game.UI.Progress
{
    [RequireComponent(typeof(Text))]
    public class LevelProgressText : MonoBehaviour
    {
        [SerializeField] private LevelProgress _levelProgress;
        
        private Text _text;

        private void Awake()
        {
            _text = GetComponent<Text>();
            HandleUpdated();
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
            _text.text = $"{_levelProgress.Killed} / {_levelProgress.KillsNeed}";
        }
    }
}