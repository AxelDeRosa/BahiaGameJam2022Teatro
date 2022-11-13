using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace NewsSystem
{
    internal sealed class NewsStorage
    {
        private readonly IDictionary<string, List<SubscriberMask>> _data = new ConcurrentDictionary<string, List<SubscriberMask>>();
        
        private static NewsStorage _instance;
        public static NewsStorage Instance => _instance ??= new NewsStorage();

        public void Store<T>(Action<T> callback) where T : class, INews, new()
        {
            var requestName = typeof(T).Name;
            if (!_data.ContainsKey(requestName))
            {
                _data[requestName] = new List<SubscriberMask>();
                
            }
            _data[requestName].Add(new SubscriberMask(new Subscriber<T>(callback)));
        }
        
        public void PublishEvent<T>(T data) where T : class, INews, new()
        {
            var requestName = typeof(T).Name;
            if (!_data.ContainsKey(requestName)) return;
            foreach (var mascara in _data[requestName])
            {
                var subscriber = mascara.Obj as Subscriber<T>;
                subscriber?.Send(data);
            }
        }
        
        private class SubscriberMask
        {
            public readonly object Obj;
            public SubscriberMask(object o)
            {
                Obj = o;
            }
        }

        
    }
}