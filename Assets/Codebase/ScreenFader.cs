using System;
using UnityEngine;

namespace Codebase
{
    public class ScreenFader : MonoBehaviour
    {
        public Animator animator;
        public event Action OnFadeOutFinished;
        
        public void OnFadeOutComplete()
        {
            OnFadeOutFinished?.Invoke();
            OnFadeOutFinished = null;
        }

        public void FadeOut(Action afterFadeOutAction)
        {
            OnFadeOutFinished += afterFadeOutAction;
            animator.Play("FadeOut");
        }

        public void FadeIn()
        {
            animator.Play("FadeIn");
        }
    }
}
