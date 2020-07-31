using SpaceShooter.Game.Bodies;
using UnityEngine;

namespace SpaceShooter.Game.ObjectManagement
{
    [RequireComponent(typeof(Health))]
    public class ClearOnDeath : MonoBehaviour
    {
        private Health _health;

        private void Awake()
        {
            _health = GetComponent<Health>();

            _health.OnDied += HandleDied;
        }

        private void HandleDied()
        {
            gameObject.SetActive(false);
            _health.Reset();
        }
    }
}