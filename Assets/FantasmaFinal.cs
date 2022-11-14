
using System;
using NewsSystem;
using UnityEngine;

public class FantasmaFinal : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void Start()
    {
        NewsStore.Subscribe<FinalFinal>(OnFinal);
    }

    private void OnFinal(FinalFinal obj)
    {
        animator.Play("Reverencia");
    }

    public void OnFinalReverencia()
    {
        
    }

    
}

public class FinalReverencia : INews
{
    public void Publish()
    {
        NewsStore.Publish(this);
    }
}

public class FinalFinal : INews
{
    public void Publish()
    {
        NewsStore.Publish(this);
    }
}