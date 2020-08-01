using UnityEngine;

namespace Common
{
    public class PrefsSave : MonoBehaviour
    {
        private void OnApplicationQuit()
        {
            PlayerPrefs.Save();
        }
    }
}