namespace NewsSystem.Sample
{
    public class EventWithData : INews
    {
        public int valueA = 1;
        public string valueB = "Hello World";
        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}