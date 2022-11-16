using MyEvents;
using NewsSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FantasmaFinal : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        NewsStore.Subscribe<FinalFinal>(OnFinal);
    }

    private void OnFinal(FinalFinal obj)
    {
        animator.Play("Final");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits",LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Gameplay");
    }

    
}