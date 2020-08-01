using System;
using Game;
using SpaceShooter.Game.Bodies;
using UnityEngine;

namespace SpaceShooter.Game.Level
{
    public class LevelProgress : MonoBehaviour
    {
        public Action OnUpdated { get; set; }
        public int KillsNeed { get; private set; }
        public int Killed { get; private set; }

        private void Awake()
        {
            KillsNeed = GameConfiguration.SelectedLevel.KillsNeed;
        }

        private void OnEnable()
        {
            Health.OnAnyDied += HandleAnyDied;
        }

        private void OnDisable()
        {
            Health.OnAnyDied -= HandleAnyDied;
        }

        private void HandleAnyDied(HealthType healthType)
        {
            if (healthType == HealthType.Enemy)
            {
                Killed++;
                OnUpdated?.Invoke();
            }
        }
    }
}