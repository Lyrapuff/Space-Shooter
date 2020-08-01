using System;
using SpaceShooter.Extensions;
using SpaceShooter.Game.Ship.Inputs;
using UnityEngine;

namespace SpaceShooter.Game.Ship.Animations
{
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(SpriteRenderer))]
    public class ShipAnimator : MonoBehaviour
    {
        [SerializeField] private IShipInputs _shipInputs;

        private Animator _animator;
        private SpriteRenderer _spriteRenderer;
        
        private static readonly int Thruster = Animator.StringToHash("Thruster");
        private static readonly int Strafe = Animator.StringToHash("Strafe");

        private void Awake()
        {
            _shipInputs = this.FindComponentByInterface<IShipInputs>();
            
            _animator = GetComponent<Animator>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
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
            bool thruster = direction != Vector3.zero;
            _animator.SetBool(Thruster, thruster);

            bool strafe = direction.x != 0f;
            _animator.SetBool(Strafe, strafe);

            _spriteRenderer.flipX = direction.x > 0f;
        }
    }
}