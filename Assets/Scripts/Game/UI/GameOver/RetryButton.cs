using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceShooter.Game.UI.GameOver
{
    public class RetryButton : MonoBehaviour
    {
        public void Retry()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}