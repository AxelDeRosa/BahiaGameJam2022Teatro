using NewsSystem;

namespace MyEvents
{
    public class FinalFinal : INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}