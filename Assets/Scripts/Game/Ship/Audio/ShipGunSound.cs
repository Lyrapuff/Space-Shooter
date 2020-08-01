using System;
using SpaceShooter.Common.Audio;
using SpaceShooter.Game.Ship.Projectile;
using UnityEngine;

namespace Game.Ship.Audio
{
    [RequireComponent(typeof(ShipGun))]
    public class ShipGunSound : MonoBehaviour
    {
        [SerializeField] private Sound _sound;
        
        private ShipGun _shipGun;

        private void Awake()
        {
            _shipGun = GetComponent<ShipGun>();
        }

        private void OnEnable()
        {
            _shipGun.OnShoot += HandleShoot;
        }

        private void OnDisable()
        {
            _shipGun.OnShoot -= HandleShoot;
        }

        private void HandleShoot()
        {
            AudioPlayer.Instance.PlaySoundOneShot(_sound);
        }
    }
}