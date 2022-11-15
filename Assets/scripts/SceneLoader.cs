using System;
using System.Collections.Generic;
using NewsSystem;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private SceneAsset[] sceneAssets;
    [SerializeField] private SceneAsset[] loadOnStart;
    [SerializeField] private Dictionary<string, SceneAsset> store = new();

    private void Awake()
    {
        foreach (var sceneAsset in sceneAssets)
        {
            store[sceneAsset.name] = sceneAsset;
        }
    }

    private void Start()
    {
        foreach (var sceneAsset in loadOnStart)
        {
            SceneManager.LoadScene(sceneAsset.name, LoadSceneMode.Additive);    
        }
    }
}
