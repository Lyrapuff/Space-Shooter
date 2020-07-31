using System.Linq;
using UnityEngine;

namespace SpaceShooter.Extensions
{
    public static class MonoBehaviourExtensions
    {
        public static T FindComponentByInterface<T>(this MonoBehaviour monoBehaviour)
        {
            T component = Object
                .FindObjectsOfType<MonoBehaviour>()
                .OfType<T>()
                .FirstOrDefault();

            return component;
        }
    }
}