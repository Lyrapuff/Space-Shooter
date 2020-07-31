using UnityEngine;

namespace SpaceShooter.Game.ObjectManagement
{
    public class GameBounds : MonoBehaviour
    {
        private void OnTriggerExit2D(Collider2D other)
        {
            other.gameObject.SetActive(false);
        }
    }
}