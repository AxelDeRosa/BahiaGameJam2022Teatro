using NewsSystem;

namespace MyEvents
{
    public class PickObject : INews
    {
        public ClickableList Clickable;

        public PickObject()
        {
        }

        public PickObject(ClickableList clickableObject)
        {
            Clickable = clickableObject;
        }

        public void Publish()
        {
            NewsStore.Publish(this);
        }
    }
}