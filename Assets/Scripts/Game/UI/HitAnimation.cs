using System;
using SpaceShooter.Game.Bodies;
using UnityEngine;

namespace SpaceShooter.Game.UI
{
    [RequireComponent(typeof(Animator))]
    public class HitAnimation : MonoBehaviour
    {
        [SerializeField] private Health _playerHealth;

        private Animator _animator;
        
        private static readonly int Hit = Animator.StringToHash("Hit");

        private void Awake()
        {
            _animator = GetComponent<Animator>();
        }

        private void OnEnable()
        {
            _playerHealth.OnHit += HandleHit;
        }

        private void OnDisable()
        {
            _playerHealth.OnHit -= HandleHit;
        }

        private void HandleHit()
        {
            _animator.SetTrigger(Hit);
        }
    }
}