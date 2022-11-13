using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        SceneManager.LoadScene("MusicSFX", LoadSceneMode.Additive);
        SceneManager.LoadScene("MenuStart", LoadSceneMode.Additive);
    }
}
