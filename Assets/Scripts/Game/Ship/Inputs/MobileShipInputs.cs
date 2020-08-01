using System;
using UnityEngine;

namespace SpaceShooter.Game.Ship.Inputs
{
    public class MobileShipInputs : MonoBehaviour, IShipInputs
    {
        public Action OnShoot { get; set; }
        public Action<Vector3> OnMove { get; set; }

        [SerializeField] private Vector2 _sensitivity;
        
        private Vector3 _lastPosition;
        
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _lastPosition = Input.mousePosition;
            }
            
            if (Input.GetMouseButton(0))
            {
                Vector3 position = Input.mousePosition;
                Vector3 deltaPosition = position - _lastPosition;
                _lastPosition = position;

                deltaPosition.x /= Screen.width;
                deltaPosition.y/= Screen.height;
                
                deltaPosition.x *= _sensitivity.x;
                deltaPosition.y *= _sensitivity.y;
                
                OnMove?.Invoke(deltaPosition);
            }
            
            OnShoot?.Invoke();
        }
    }
}