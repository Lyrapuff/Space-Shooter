using System;
using UnityEngine;

namespace SpaceShooter.Game.Ship.Inputs
{
    public class PCShipInputs : MonoBehaviour, IShipInputs
    {
        public Action OnShoot { get; set; }
        public Action<Vector3> OnMove { get; set; }

        private void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            
            Vector3 direction = new Vector3(horizontal, vertical, 0f);
            OnMove?.Invoke(direction);

            if (Input.GetButton("Shoot"))
            {
                OnShoot?.Invoke();
            }
        }
    }
}