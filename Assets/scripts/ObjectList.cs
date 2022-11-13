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

    private void Start()
    {
        NewsStore.Subscribe<ObjectLoaded>(LoadObject);
        NewsStore.Subscribe<PickObject>(PickObject);
    }

    private void LoadObject(ObjectLoaded objectLoaded)
    {
        var obj = objectLoaded.obj;
        var objName = obj.FantasmaConTexto.name;
        _pickeables[objName] = obj;
        Debug.Log(obj.name);
        Debug.Log(objName);
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
            _pickeables[name].enabled = true;
        }

    }

}
