using UnityEngine;

namespace SpaceShooter.Game.Bodies
{
    public class RandomMovement : MonoBehaviour
    {
        private Vector3 _direction;

        private void Awake()
        {
            _direction = Random.insideUnitSphere * 0.3f;
            _direction.z = 0f;
        }

        private void Update()
        {
            transform.position += _direction * Time.deltaTime;
        }
    }
}