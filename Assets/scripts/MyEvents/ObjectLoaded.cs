using NewsSystem;
using UnityEngine;

namespace MyEvents
{
    public class ObjectLoaded : INews
    {
        public ClickableObject obj;
        
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}