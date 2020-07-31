using SpaceShooter.Game.Bodies;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceShooter.UI.Game
{
    [RequireComponent(typeof(Text))]
    public class HealthText : MonoBehaviour
    {
        [SerializeField] private Health _health;

        private Text _text;
        
        private void Start()
        {
            _text = GetComponent<Text>();

            _health.OnHit += Display;
            
            Display();
        }

        private void Display()
        {
            _text.text = _health.HitCount.ToString();
        }
    }
}