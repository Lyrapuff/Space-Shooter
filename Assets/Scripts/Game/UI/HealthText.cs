using SpaceShooter.Game.Bodies;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceShooter.Game.UI
{
    [RequireComponent(typeof(Text))]
    public class HealthText : MonoBehaviour
    {
        [SerializeField] private Health _health;

        private Text _text;
        
        private void Start()
        {
            _text = GetComponent<Text>();
            
            Display();
        }

        private void OnEnable()
        {
            _health.OnHit += Display;
        }

        private void OnDisable()
        {
            _health.OnHit -= Display;
        }

        private void Display()
        {
            _text.text = _health.HitCount.ToString();
        }
    }
}