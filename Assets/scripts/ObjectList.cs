using System.Collections.Generic;
using MyEvents;
using NewsSystem;
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
        _pickeables[obj.name] = obj;
        Debug.Log(_pickeables.Count);
        if (_pickeables.Count > 1)
        {
            obj.gameObject.SetActive(false);
        }
    }

    private void PickObject(PickObject data)
    {
        if(count >= orderList.Length) return;
        var name = orderList[count].name;
        if (data.obj == name)
        {
            //algo
            count++;
        }
       
    }

}
