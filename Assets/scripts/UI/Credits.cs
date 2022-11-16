using MyEvents;
using NewsSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI
{
    public class Credits : MonoBehaviour
    {
        private void Start()
        {
            NewsStore.Publish<CreditsLoaded>();
        }
        
        public void StartMenu()
        {
            NewsStore.Publish<ButtonClicked>();
            SceneManager.LoadScene("MenuStart",LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("Credits");
        }
    }
}