using NewsSystem;
using UnityEngine;

namespace MyEvents
{
    public class ObjectLoaded : INews
    {
        public GameObject obj;
        
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}