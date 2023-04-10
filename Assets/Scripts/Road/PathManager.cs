using System;
using System.Collections.Generic;
using Road.Interface;
using UnityEngine;
using UnityEngine.Events;

namespace Road
{
    public class PathManager : MonoBehaviour
    {
        [SerializeField] private GameObject roadPrefab;
        
        private UnityEvent<IRoad> _onSpawnRoad = new UnityEvent<IRoad>();

        private void Awake()
        {
            _onSpawnRoad.AddListener(SpawnNewRoad);
        }
        
        public UnityEvent<IRoad> OnSpawnRoad()
        {
            return _onSpawnRoad;
        }

        private void SpawnNewRoad(IRoad road)
        {
            Transform newRoadPosition = road.GetSpawnPositions();

            GameObject newRoad = Instantiate(roadPrefab,gameObject.transform,true);
            
            newRoad.GetComponent<IRoad>().SetPositions(newRoadPosition);
        }
    }
}
