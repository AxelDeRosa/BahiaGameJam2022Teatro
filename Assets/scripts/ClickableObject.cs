using MyEvents;
using NewsSystem;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] private ClickableList clickableObject;

    private void Start()
    {
        NewsStore.Publish(new ObjectLoaded
        {
            obj = this
        });
    }

    public void OnClick()
    {
        NewsStore.Publish(new PickObject(clickableObject));
        gameObject.SetActive(false);
    }

    public ClickableList GetClickable()
    {
        return clickableObject;
    }
}