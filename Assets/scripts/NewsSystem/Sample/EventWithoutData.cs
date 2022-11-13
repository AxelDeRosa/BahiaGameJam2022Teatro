namespace NewsSystem.Sample
{
    public class EventWithoutData : INews
    {
        public void Publish()
        {
            NewsStore.Publish(this);
        }

    }
}