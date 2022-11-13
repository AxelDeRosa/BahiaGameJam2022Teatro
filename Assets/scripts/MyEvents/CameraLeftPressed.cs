using NewsSystem;

namespace MyEvents
{
    public class CameraLeftPressed :INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}