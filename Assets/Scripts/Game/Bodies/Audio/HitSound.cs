using System;
using SpaceShooter.Common.Audio;
using UnityEngine;

namespace SpaceShooter.Game.Bodies.Audio
{
    [RequireComponent(typeof(HitOnTouch))]
    public class HitSound : MonoBehaviour
    {
        [SerializeField] private Sound _sound;

        private HitOnTouch _hitOnTouch;

        private void Awake()
        {
            _hitOnTouch = GetComponent<HitOnTouch>();
        }

        private void OnEnable()
        {
            _hitOnTouch.OnHit += HandleHit;
        }

        private void OnDisable()
        {
            _hitOnTouch.OnHit -= HandleHit;
        }

        private void HandleHit()
        {
            AudioPlayer.Instance.PlaySoundOneShot(_sound);
        }
    }
}