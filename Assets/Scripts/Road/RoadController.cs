using System;
using Road.Interface;
using UnityEngine;

namespace Road
{
    public class RoadController : MonoBehaviour,IRoad
    {
        private Transform _newRoadTransform;

        private void Awake()
        {
            _newRoadTransform = GetComponentInChildren<Transform>();
        }

        public Transform GetSpawnPositions()
        {
            return _newRoadTransform;
        }

        public void SetPositions(Transform position)
        {
            gameObject.transform.position = transform.position;
        }
        
    }
}
