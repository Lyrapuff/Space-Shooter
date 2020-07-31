using UnityEngine;

namespace SpaceShooter.Game.ObjectManagement
{
    [RequireComponent(typeof(ObjectPool))]
    public class TimedSpawner : MonoBehaviour
    {
        [Tooltip("How many to spawn in one second.")]
        [SerializeField] private float _spawnRate;
        [SerializeField] private float _randomPositionRange;

        private ObjectPool _objectPool;
        private float _spawnDelay;
        private float _timer;

        private void Awake()
        {
            _objectPool = GetComponent<ObjectPool>();
            
            _spawnDelay = 1f / _spawnRate;
        }

        private void Update()
        {
            _timer += Time.deltaTime;

            if (_timer >= _spawnDelay)
            {
                _timer = 0f;
                Spawn();
            }
        }

        private void Spawn()
        {
            Transform instance = _objectPool.Create().transform;

            float x = Random.Range(-_randomPositionRange, _randomPositionRange);
            
            instance.localPosition = new Vector3(x, 0f, 0f);
        }
    }
}