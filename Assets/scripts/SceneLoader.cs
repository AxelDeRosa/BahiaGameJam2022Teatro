using System;
using System.Collections.Generic;
using NewsSystem;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private string[] loadOnStart;


    private void Start()
    {
        foreach (var sceneAsset in loadOnStart)
        {
            SceneManager.LoadScene(sceneAsset, LoadSceneMode.Additive);    
        }
    }
}
