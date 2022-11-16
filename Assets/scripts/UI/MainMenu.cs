using MyEvents;
using NewsSystem;
using NewsSystem.Sample;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class MainMenu : MonoBehaviour
    {
        private void Start()
        {
            NewsStore.Publish<MainMenuLoaded>();
        }

        public void ExitGame()
        {
            NewsStore.Publish<ButtonClicked>();
            Application.Quit();
        }

        public void StartGame()
        {
            NewsStore.Publish<ButtonClicked>();
            SceneManager.LoadScene("Gameplay",LoadSceneMode.Additive);
            NewsStore.Publish<LevelLoaded>();
            SceneManager.UnloadSceneAsync("MenuStart");
        }

        public void StartCredits()
        {
            
        }
    }
}
