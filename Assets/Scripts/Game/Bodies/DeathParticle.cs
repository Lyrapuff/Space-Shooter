using UnityEngine;

namespace SpaceShooter.Game.Bodies
{
    [RequireComponent(typeof(Health))]
    public class DeathParticle : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;

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
            Transform instance = Instantiate(_prefab).transform;
            instance.position = transform.position;
        }
    }
}