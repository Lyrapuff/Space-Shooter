using SpaceShooter.Game.ObjectManagement;
using SpaceShooter.Game.Ship.Inputs;
using UnityEngine;

namespace SpaceShooter.Game.Ship.Projectile
{
    [RequireComponent(typeof(IShipInputs))]
    public class ShipGun : MonoBehaviour
    {
        [Tooltip("In seconds.")]
        [SerializeField] private float _reloadTime;
        [SerializeField] private ObjectPool _projectilePool;

        private IShipInputs _shipInputs;
        private float _shootTime;

        private void Awake()
        {
            _shipInputs = GetComponent<IShipInputs>();

            _shipInputs.OnShoot += HandleShoot;
        }

        private void HandleShoot()
        {
            if (Time.time > _shootTime + _reloadTime)
            {
                Transform projectile = _projectilePool.Create().transform;
                projectile.position = transform.position + Vector3.up * 0.5f;
                _shootTime = Time.time;
            }
        }
    }
}