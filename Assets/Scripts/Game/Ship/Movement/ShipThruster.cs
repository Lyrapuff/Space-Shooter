using System;
using SpaceShooter.Game.Ship.Inputs;
using UnityEngine;

namespace SpaceShooter.Game.Ship.Movement
{
    [RequireComponent(typeof(IShipInputs))]
    public class ShipThruster : MonoBehaviour
    {
        [SerializeField] private float _speed;
        
        private IShipInputs _shipInputs;

        private void Awake()
        {
            _shipInputs = GetComponent<IShipInputs>();
        }

        private void OnEnable()
        {
            _shipInputs.OnMove += HandleMove;
        }

        private void OnDisable()
        {
            _shipInputs.OnMove -= HandleMove;
        }

        private void HandleMove(Vector3 direction)
        {
            Vector3 movement = new Vector3(direction.x, direction.y, 0f) * (_speed * Time.deltaTime);

            transform.position += movement;
            
            ClampPosition();
        }

        private void ClampPosition()
        {
            Vector3 position = transform.position;
            position.x = Mathf.Clamp(position.x, -2f, 2f);
            position.y = Mathf.Clamp(position.y, -4.5f, 4f);
            transform.position = position;
        }
    }
}