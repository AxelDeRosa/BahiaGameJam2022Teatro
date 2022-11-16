using NewsSystem;

namespace MyEvents
{
    public class DialogLoaded : INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}