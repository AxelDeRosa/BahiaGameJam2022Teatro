using NewsSystem;

namespace MyEvents
{
    public class ButtonClicked :INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}