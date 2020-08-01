using SpaceShooter.Common.Audio;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SpaceShooter.Menu.UI
{
    public class HoverSound : MonoBehaviour, IPointerEnterHandler
    {
        [SerializeField] private Sound _sound;
        
        public void OnPointerEnter(PointerEventData eventData)
        {
            AudioPlayer.Instance.PlaySoundOneShot(_sound);
        }
    }
}