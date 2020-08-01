using System;
using UnityEngine;

namespace SpaceShooter.Game.Ship.Inputs
{
    public class PCShipInputs : MonoBehaviour, IShipInputs
    {
        public Action OnShoot { get; set; }
        public Action<Vector3> OnMove { get; set; }
        public Vector2 Direction { get; private set; }

        private void Update()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            
            Direction = new Vector2(horizontal, vertical);

            if (Input.GetButton("Shoot"))
            {
                OnShoot?.Invoke();
            }
        }
    }
}