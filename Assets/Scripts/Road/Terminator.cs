using System;
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
            if (other.gameObject.GetComponent<RoadController>() != null)
            {
                Destroy(other.gameObject);
                _pathManager.OnSpawnRoad().Invoke(other.gameObject.transform);
            }
        }   
    }
}
