using SpaceShooter.Game.Bodies;
using UnityEngine;

namespace SpaceShooter.Game.ObjectManagement
{
    [RequireComponent(typeof(HitOnTouch))]
    public class ClearOnHit : MonoBehaviour
    {
        private HitOnTouch _hitOnTouch;

        private void Awake()
        {
            _hitOnTouch = GetComponent<HitOnTouch>();

            _hitOnTouch.OnHit += HandleHit;
        }

        private void HandleHit()
        {
            gameObject.SetActive(false);
        }
    }
}