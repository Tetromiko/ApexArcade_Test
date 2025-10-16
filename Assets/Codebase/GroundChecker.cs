using UnityEngine;

namespace Codebase
{
    public class GroundChecker : MonoBehaviour
    {
        [SerializeField] private LayerMask groundLayer;
        [SerializeField] private float checkRadius;

        public void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position, checkRadius);
        }

        public bool Check() => Physics.CheckSphere(transform.position, checkRadius, groundLayer);
    }
}
