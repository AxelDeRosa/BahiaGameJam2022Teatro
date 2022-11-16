using MyEvents;
using NewsSystem;
using UnityEngine;
using UnityEngine.UI;

public class HideOnDialogs : MonoBehaviour
{
    [SerializeField] private Image image;
    
    void Start()
    {
       NewsStore.Subscribe<DialogLoaded>(Hide);
       NewsStore.Subscribe<DialogUnloaded>(Show);
    }

    private void Hide(DialogLoaded _)
    {
        var imageColor = image.color;
        imageColor.a = 0;
        image.raycastTarget = false;
        image.color = imageColor;
    }

    private void Show(DialogUnloaded _)
    {
        var imageColor = image.color;
        imageColor.a = 1;
        image.raycastTarget = true;
        image.color = imageColor;
    }
}