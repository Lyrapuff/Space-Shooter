using UnityEngine;

namespace SpaceShooter.Menu.UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class SwitchGroup : MonoBehaviour
    {
        private CanvasGroup _canvasGroup;

        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        public void Switch()
        {
            bool state = _canvasGroup.interactable;

            _canvasGroup.interactable = !state;
            _canvasGroup.blocksRaycasts = !state;
            _canvasGroup.alpha = state ? 0f : 1f;
        }
    }
}