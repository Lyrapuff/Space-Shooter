using System;
using UnityEngine;

namespace SpaceShooter.Common.Audio
{
    [Serializable]
    public struct Sound
    {
        public AudioClip AudioClip => _audioClip;
        public float Volume => _volume;
        
        [SerializeField] private AudioClip _audioClip;
        [Range(0f, 1f)]
        [SerializeField] private float _volume;
    }
}