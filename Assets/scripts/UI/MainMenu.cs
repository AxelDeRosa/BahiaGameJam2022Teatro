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
            Application.Quit();
        }

        public void StartGame()
        {
            SceneManager.LoadScene("SampleScene",LoadSceneMode.Additive);
            NewsStore.Publish<LevelLoaded>();
            SceneManager.UnloadSceneAsync("MenuStart");
        }
    }
}
