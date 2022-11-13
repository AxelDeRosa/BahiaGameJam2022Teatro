using UnityEngine;

namespace NewsSystem.Sample
{
    public class TestNews : MonoBehaviour
    {
        private void Start()
        {
            NewsStore.Subscribe<EventWithoutData>(OnEventWithoutData);
            NewsStore.Subscribe<EventWithData>(OnEventWithData);
            
            var testWithData = new EventWithData
            {
                valueA = 44,
                valueB = "Nuevo valor"
            };
            testWithData.Publish();
            NewsStore.Publish(testWithData);
            NewsStore.Publish<EventWithData>(); // Si los valores default del evento están bien no hace falta crearlo
            NewsStore.Publish<EventWithoutData>();
        }

        private void OnEventWithData(EventWithData obj)
        {
            Debug.Log("Event with data triggered: A="+obj.valueA+" "+"B="+obj.valueB);
        }

        private void OnEventWithoutData(EventWithoutData obj)
        {
            Debug.Log("Event without data triggered");
        }
    }
}