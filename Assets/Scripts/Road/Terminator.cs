
using Road.Interface;
using UnityEngine;

namespace Road
{
    public class Terminator : MonoBehaviour
    {
        private PathManager _pathManager;

        private void Awake()
        {
            _pathManager = FindObjectOfType<PathManager>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<IRoad>() != null)
            {
                _pathManager.OnSpawnRoad().Invoke(other.GetComponent<IRoad>());
                Destroy(other.gameObject);
            }
        }
    }
}
