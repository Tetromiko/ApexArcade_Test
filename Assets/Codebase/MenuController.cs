using UnityEngine;
using UnityEngine.SceneManagement;

namespace Codebase
{
    public class MenuController : MonoBehaviour
    {
        public ScreenFader screenFader;

        public void OnEnable()
        {
            screenFader.FadeIn();
        }

        private void OnStartGame()
        {
            screenFader.FadeOut(StartGame);
        }
        private void StartGame()
        {
            SceneManager.LoadScene("Game");
        }
        
        private void OnQuitGame()
        {
            screenFader.FadeOut(QuitGame);
        }

        private void QuitGame()
        {
            Debug.Log("Quit");
            Application.Quit();
        }
    }
}
