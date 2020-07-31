using UnityEngine;

namespace SpaceShooter.Game.Ship.Projectile
{
    public class ProjectileMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private void Update()
        {
            transform.position += Vector3.up * (_speed * Time.deltaTime);
        }
    }
}