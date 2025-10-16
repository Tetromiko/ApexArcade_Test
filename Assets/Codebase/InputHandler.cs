using UnityEngine;

namespace Codebase
{
    public class InputHandler : MonoBehaviour
    {
        public KeyCode left;
        public KeyCode right;
        public KeyCode jump;
    
        public PlayerController player;
    
        public void Update()
        {
            var totalInput = 0;
        
            if (Input.GetKey(left))
                totalInput -= 1;

            if (Input.GetKey(right))
                totalInput += 1;
        
            if (totalInput != 0)
                player.Move(totalInput);

            if (Input.GetKeyDown(jump))
                player.Jump();
        }
    }
}