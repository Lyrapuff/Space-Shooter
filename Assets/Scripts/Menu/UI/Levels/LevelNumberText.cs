using UnityEngine;
using UnityEngine.UI;

namespace SpaceShooter.Menu.UI.Levels
{
    [RequireComponent(typeof(Text))]
    public class LevelNumberText : MonoBehaviour
    {
        [SerializeField] private LevelButton _levelButton;

        private void Start()
        {
            Text text = GetComponent<Text>();

            text.text = _levelButton.Level.Number.ToString();
        }
    }
}