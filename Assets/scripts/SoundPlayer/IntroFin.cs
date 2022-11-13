using NewsSystem;

namespace SoundPlayer
{
    public class IntroFin : INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}