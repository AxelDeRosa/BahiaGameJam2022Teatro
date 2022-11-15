using System.Collections.Generic;
using MyEvents;
using NewsSystem;
using UnityEngine;

public class ObjectList : MonoBehaviour
{
    [SerializeField] private ClickableList[] orderList;
    private readonly Dictionary<ClickableList, ClickableObject> pickable = new();
    private int count;

    private void Awake()
    {
        NewsStore.Subscribe<ObjectLoaded>(LoadObject);
    }

    private void Start()
    {
        
        NewsStore.Subscribe<PickObject>(PickObject);
    }

    private void LoadObject(ObjectLoaded objectLoaded)
    {
        var obj = objectLoaded.obj;
        var clickable = obj.GetClickable();
        pickable[clickable] = obj;
        if (clickable != orderList[0])
        {
            obj.gameObject.SetActive(false);
        }
    }

    private void PickObject(PickObject data)
    {
        if(count >= orderList.Length) return;
        var name = orderList[count];
        if (data.Clickable != name) return;
        
        NewsStore.Publish(new PlayVoice
        {
            voice = name.ToString()
        });
        count++;
        if (count < pickable.Count)
        {
            pickable[orderList[count]].gameObject.SetActive(true);
        }
    }

}
