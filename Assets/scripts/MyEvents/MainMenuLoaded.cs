using NewsSystem;

namespace MyEvents
{
    public class MainMenuLoaded : INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}