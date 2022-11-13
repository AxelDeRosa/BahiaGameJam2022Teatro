using NewsSystem;

namespace MyEvents
{
    public class LevelLoaded : INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}