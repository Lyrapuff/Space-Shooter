using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceShooter.Game.UI.Complete
{
    public class LoadSceneButton : MonoBehaviour
    {
        public void Load(int buildIndex)
        {
            SceneManager.LoadScene(buildIndex);
            Time.timeScale = 1f;
        }
    }
}