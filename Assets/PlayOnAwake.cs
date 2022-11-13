using System;
using System.Collections;
using System.Collections.Generic;
using MyEvents;
using NewsSystem;
using SoundPlayer;
using UnityEngine;

public class PlayOnAwake : MonoBehaviour
{
    private void Awake()
    {
        NewsStore.Subscribe<IntroFin>(fin => gameObject.SetActive(false) );
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
