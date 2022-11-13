using System;
using UnityEngine;
using Object = System.Object;

namespace NewsSystem
{
    public static class NewsStore
    {
        public static void Subscribe<T>(Action<T> callback) where T : class, INews, new()
        {
            NewsStorage.Instance.Store(callback);
        }

        public static void Publish<T>(T data) where T : class, INews, new()
        {
            NewsStorage.Instance.PublishEvent(data);
        }

        public static void Publish<T>() where T : class, INews, new()
        {
            NewsStorage.Instance.PublishEvent(new T());
        }
        
    }
}