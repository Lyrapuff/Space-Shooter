using System.Collections;
using SpaceShooter.Game.Level;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceShooter.Game.UI.Progress
{
    [RequireComponent(typeof(Image))]
    public class LevelProgressBar : MonoBehaviour
    {
        [SerializeField] private LevelProgress _levelProgress;
        
        private Image _image;
        private Coroutine _animation;

        private void Awake()
        {
            _image = GetComponent<Image>();
            
            HandleUpdated();
        }
        
        private void OnEnable()
        {
            _levelProgress.OnUpdated += HandleUpdated;
        }

        private void OnDisable()
        {
            _levelProgress.OnUpdated -= HandleUpdated;
        }

        private void HandleUpdated()
        {
            if (_animation != null)
            {
                StopCoroutine(_animation);
            }
            
            _animation = StartCoroutine(Animate());
        }

        private IEnumerator Animate()
        {
            float time = 0f;
            float currentX = _image.rectTransform.localScale.x;
            float x = (float)_levelProgress.Killed / _levelProgress.KillsNeed;

            while (time <= 1f)
            {
                _image.rectTransform.localScale = new Vector3(Mathf.Lerp(currentX, x, time), 1f, 1f);
                
                time += Time.fixedDeltaTime * 5f;
                yield return new WaitForFixedUpdate();
            }
        }
    }
}