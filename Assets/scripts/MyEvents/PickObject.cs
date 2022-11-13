﻿using NewsSystem;

namespace MyEvents
{
    public class PickObject :INews
    {
        public string obj;
        
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}