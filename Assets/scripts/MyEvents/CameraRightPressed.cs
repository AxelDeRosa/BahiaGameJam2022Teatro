using NewsSystem;

namespace MyEvents
{
    public class CameraRightPressed :INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}