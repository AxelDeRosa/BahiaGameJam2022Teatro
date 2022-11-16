using System;
using MyEvents;
using NewsSystem;
using UnityEngine;

public class ObjectPopUp : MonoBehaviour
{
    [SerializeField] private ClickableList clickableList;
    [SerializeField] private Canvas canvas;

    private void Start()
    {
        NewsStore.Subscribe<PickObject>(OnPickObject);
        if (clickableList == ClickableList.Dress)
        {
            NewsStore.Subscribe<FinalFinal>(_ => canvas.gameObject.SetActive(false));
        }
    }

    private void OnPickObject(PickObject obj)
    {
        if (obj.Clickable != clickableList) return;
        canvas.gameObject.SetActive(true);
        NewsStore.Publish<DialogLoaded>();
    }

    public void EndPopUp()
    {
        NewsStore.Publish<DialogUnloaded>();
    }
}