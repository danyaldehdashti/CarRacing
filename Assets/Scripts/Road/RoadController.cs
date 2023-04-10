
using UnityEngine;

namespace Road
{
    public class RoadController : MonoBehaviour
    {
        private const float NewRoadPosition = -59;
        
        public void SetPositions(Transform tran)
        {
            gameObject.transform.position = tran.position + new Vector3(0,0,NewRoadPosition);
        }
        
    }
}
