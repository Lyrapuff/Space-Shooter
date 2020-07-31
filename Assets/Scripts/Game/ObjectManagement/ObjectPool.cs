using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SpaceShooter.Game.ObjectManagement
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        
        private List<GameObject> _pool = new List<GameObject>();

        public GameObject Create()
        {
            GameObject go = _pool.FirstOrDefault(instance => !instance.activeSelf);

            if (go == null)
            {
                go = Instantiate(_prefab, transform);
                _pool.Add(go);
            }
            else
            {
                go.SetActive(true);
            }

            return go;
        }
    }
}