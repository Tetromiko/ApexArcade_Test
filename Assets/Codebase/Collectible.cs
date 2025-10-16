using System;
using UnityEngine;

namespace Codebase
{
    public class Collectible : MonoBehaviour
    {
        [SerializeField]
        private Animator animator;
        [SerializeField] 
        private int value;
        
        public event Action<int> OnCollected;

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                animator.Play("Disappear");
                GetComponent<Collider>().enabled = false;
                OnCollected?.Invoke(value);
            }
        }
        
        public void OnDisappearComplete()
        {
            Destroy(gameObject);
        }
    }
}
