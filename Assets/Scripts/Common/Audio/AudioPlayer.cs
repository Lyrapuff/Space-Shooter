using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter.Common.Audio
{
    public class AudioPlayer : MonoBehaviour
    {
        public static AudioPlayer Instance { get; private set; }

        private Dictionary<Sound, AudioSource> _audioSources;
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else if (Instance != this)
            {
                Destroy(gameObject);
            }

            _audioSources = new Dictionary<Sound, AudioSource>();
        }

        private AudioSource GetAudioSource(Sound sound)
        {
            AudioSource audioSource;
            
            if (_audioSources.ContainsKey(sound))
            {
                audioSource = _audioSources[sound];
            }
            else
            {
                audioSource = gameObject.AddComponent<AudioSource>();
                _audioSources[sound] = audioSource;
            }

            return audioSource;
        }
        
        public void PlaySound(Sound sound, bool loop = false)
        {
            AudioSource audioSource = GetAudioSource(sound);

            audioSource.clip = sound.AudioClip;
            audioSource.volume = sound.Volume;
            audioSource.loop = loop;
            audioSource.Play();
        }

        public void PlaySoundOneShot(Sound sound)
        {
            AudioSource audioSource = GetAudioSource(sound);

            audioSource.PlayOneShot(sound.AudioClip, sound.Volume);
        }
    }
}