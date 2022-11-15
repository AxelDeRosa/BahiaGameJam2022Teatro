
using System;
using MyEvents;
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
        animator.Play("Final");
    }

    
}