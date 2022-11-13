using NewsSystem;
using UnityEngine;

namespace MyEvents
{
    public class ObjectLoaded : INews
    {
        public objetoInteractuable obj;
        
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}