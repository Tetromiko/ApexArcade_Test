using System.Collections.Generic;
using UnityEngine;

namespace Codebase
{
    public class CollectibleSpawner : MonoBehaviour
    {
        public List<Collectible> collectibles;

        [SerializeField]
        private float timer;
        [SerializeField]
        private float respawnTime;

        [SerializeField]
        private Collectible currentCollectible;
        [SerializeField]
        private ScoreCounter scoreCounter;

        public void FixedUpdate()
        {
            if(currentCollectible) return;
            
            if ((timer += Time.fixedDeltaTime) > respawnTime)
            {
                timer = 0;
                var index = Random.Range(0, collectibles.Count);
                currentCollectible = Instantiate(collectibles[index], transform.position, transform.rotation);
                scoreCounter.RegisterCollectible(currentCollectible);
            }
        }
    }
}