using UnityEngine;

namespace Codebase
{
    public class ScreenShaker : MonoBehaviour
    {
        public AnimationCurve intensityCurve;
        [SerializeField]
        private float timer;
        [SerializeField]
        private Vector2 destination = Vector2.zero;
        [SerializeField]
        private float duration;
        [SerializeField]
        private float amplitude;
        [SerializeField]
        public float intensity;
        [SerializeField]
        public float distance;

        public void Initialize(float duration, float amplitude, float intensity)
        {
            timer = 0;
            this.amplitude = amplitude;
            this.duration = duration;
            this.intensity = intensity;
        }

        public void FixedUpdate()
        {
            if ((timer += Time.fixedDeltaTime) < duration)
            {
                if (Vector2.Distance(transform.localPosition, destination) < 0.01)
                {
                    destination = new Vector2(Random.Range(-amplitude, amplitude), Random.Range(-amplitude, amplitude)) * intensityCurve.Evaluate(timer/duration);
                    distance = Vector2.Distance(transform.localPosition, destination);
                }
            
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, destination, intensity * distance * Time.fixedDeltaTime);
            }
            else
            {
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, Vector2.zero, intensity * distance * Time.fixedDeltaTime);
            }
        }
    }
}