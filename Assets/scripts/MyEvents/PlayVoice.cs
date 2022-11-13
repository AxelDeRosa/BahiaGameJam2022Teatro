using NewsSystem;

namespace MyEvents
{
    public class PlayVoice :INews
    {
        public string voice;
        
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}