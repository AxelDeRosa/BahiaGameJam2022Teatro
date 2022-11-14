using System;
using System.Collections.Generic;
using MyEvents;
using NewsSystem;
using TMPro;
using UnityEngine;

public class ObjectList : MonoBehaviour
{
    [SerializeField] private GameObject[] orderList;
    private Dictionary<string, objetoInteractuable> _pickeables = new Dictionary<string, objetoInteractuable>();
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
        var objName = obj.FantasmaConTexto.name;
        _pickeables[objName] = obj;
        if (objName != orderList[0].name)
        {
            obj.gameObject.SetActive(false);
        }
    }

    private void PickObject(PickObject data)
    {
        if(count >= orderList.Length) return;
        var name = orderList[count].name;
        if (data.obj != name) return;
        
        NewsStore.Publish(new PlayVoice
        {
            voice = name
        });
        count++;
        if (count < _pickeables.Count)
        {
            _pickeables[ orderList[count].name].gameObject.SetActive(true);
        }
        else
        {
            NewsStore.Publish<FinalFinal>();
        }

    }

}
