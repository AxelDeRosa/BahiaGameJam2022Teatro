using NewsSystem;

namespace MyEvents
{
    public class DialogUnloaded : INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}