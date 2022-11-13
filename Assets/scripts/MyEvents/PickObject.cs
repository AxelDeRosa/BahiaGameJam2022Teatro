using NewsSystem;

namespace MyEvents
{
    public class PickObject :INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}