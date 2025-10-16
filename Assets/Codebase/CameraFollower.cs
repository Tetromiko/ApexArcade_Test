using UnityEngine;

namespace Codebase
{
    public class CameraFollower : MonoBehaviour
    {
        public Transform target;
        public float distance = 5f;
    
        public float smoothTime = 0.2f;
        [SerializeField]
        private Vector3 velocity = Vector3.zero;
    
        void LateUpdate()
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, -distance);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}