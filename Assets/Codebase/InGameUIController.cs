using UnityEngine;

namespace Codebase
{
    public class InGameUIController : MonoBehaviour
    {
        public ScreenFader screenFader;
        public void OnEnable()
        {
            screenFader.FadeIn();
        }
    }
}