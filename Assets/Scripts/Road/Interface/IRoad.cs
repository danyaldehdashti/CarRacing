using UnityEngine;
using UnityEngine.UIElements;

namespace Road.Interface
{
    public interface IRoad
    {
        Transform GetSpawnPositions();
        void SetPositions(Transform position);
    }
}
