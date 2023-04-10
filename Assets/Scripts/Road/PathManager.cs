using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Road
{
    public class PathManager : MonoBehaviour
    {
        [SerializeField] private GameObject roadPrefab;
        
        public  List<RoadController> _roads;

        private UnityEvent<Transform> _onSpawnRoad;

        private void Awake()
        {
            _roads = new List<RoadController>(GetComponentsInChildren<RoadController>());
            if (_onSpawnRoad == null)
                _onSpawnRoad = new UnityEvent<Transform>();
            
            
            _onSpawnRoad.AddListener(SpawnNewRoad);
        }
        
        public UnityEvent<Transform> OnSpawnRoad()
        {
            return _onSpawnRoad;
        }

        private void SpawnNewRoad(Transform tran)
        {
            GameObject newRoad = Instantiate(roadPrefab,gameObject.transform,true);
            
            newRoad.GetComponent<RoadController>().SetPositions(tran);
            
            _roads.RemoveAt(0);

            _roads.Add(newRoad.GetComponent<RoadController>());
        }
    }
}
