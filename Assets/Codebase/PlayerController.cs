using UnityEngine;

namespace Codebase
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] 
        private Rigidbody rb;
        [SerializeField] 
        private GroundChecker groundChecker;
        [SerializeField]
        private ScreenShaker screenShaker;
        [SerializeField]
        private float jumpForce;
        [SerializeField]
        private float speed;

        private void OnCollisionEnter(Collision other)
        {
            screenShaker.Initialize(0.1f + rb.velocity.magnitude / 100,0.05f, 32);
        }

        public void Jump()
        {
            if (groundChecker.Check())
                rb.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
        }

        public void Move(float direction)
        {
            rb.AddForce(Vector2.right * direction * speed, ForceMode.Acceleration);
        }

        public void FixedUpdate()
        {
            if (Mathf.Abs(rb.velocity.x) > speed)
            {
                rb.velocity = new Vector2(rb.velocity.x * 0.9f, rb.velocity.y);
            }
        }
    }
}