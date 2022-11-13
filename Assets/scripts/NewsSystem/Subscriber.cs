using System;

namespace NewsSystem
{
    internal sealed class Subscriber<T> where T : class, INews, new()
    {
        private readonly Action<T> _callback;

        public Subscriber(Action<T> callback)
        {
            _callback = callback;
        }
        
        public void Send(T gameRequest)
        {
            _callback?.Invoke(gameRequest);
        }
    }
}