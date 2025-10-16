using System;
using UnityEngine;

namespace Codebase
{
    public class ScoreCounter : MonoBehaviour
    {
        [SerializeField]
        private int currentScore;
        
        public event Action<int> OnScoreChanged;

        public void Change(int value)
        {
            currentScore += value;
            OnScoreChanged?.Invoke(currentScore);
        }

        public void RegisterCollectible(Collectible collectible)
        {
            collectible.OnCollected += Change;
        }
    }
}