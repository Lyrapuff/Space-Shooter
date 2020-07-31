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

        private void Update()
        {
            Vector2 direction = _shipInputs.Direction;
            Vector3 movement = new Vector3(direction.x, direction.y, 0f) * (_speed * Time.deltaTime);

            transform.position += movement;
        }
    }
}