using UnityEngine;

namespace SpaceShooter.Game.Bodies
{
    public class RandomRotation : MonoBehaviour
    {
        private float _speed;

        private void Awake()
        {
            _speed = Random.Range(-20f, 20f);
        }

        private void Update()
        {
            transform.Rotate(new Vector3(0f, 0f, _speed * Time.deltaTime));
        }
    }
}