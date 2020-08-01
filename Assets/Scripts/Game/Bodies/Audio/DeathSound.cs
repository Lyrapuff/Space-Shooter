using SpaceShooter.Common.Audio;
using UnityEngine;

namespace SpaceShooter.Game.Bodies.Audio
{
    [RequireComponent(typeof(Health))]
    public class DeathSound : MonoBehaviour
    {
        [SerializeField] private Sound _sound;

        private Health _health;

        private void Awake()
        {
            _health = GetComponent<Health>();
        }

        private void OnEnable()
        {
            _health.OnDied += HandleDied;
        }

        private void OnDisable()
        {
            _health.OnDied -= HandleDied;
        }

        private void HandleDied()
        {
            AudioPlayer.Instance.PlaySoundOneShot(_sound);
        }
    }
}