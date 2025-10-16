using UnityEngine;
using UnityEngine.UI;

namespace Codebase
{
    public class ScoreCounterUI : MonoBehaviour
    {
        [SerializeField]
        private ScoreCounter scoreCounter;

        [SerializeField] private Text text;

        public void OnEnable()
        {
            scoreCounter.OnScoreChanged += UpdateUI;
        }

        public void OnDisable()
        {
            scoreCounter.OnScoreChanged -= UpdateUI;
        }

        public void UpdateUI(int value)
        {
            text.text = value.ToString();
        }
    }
}