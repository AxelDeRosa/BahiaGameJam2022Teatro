using NewsSystem;

namespace MyEvents
{
    public class CreditsLoaded :INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}