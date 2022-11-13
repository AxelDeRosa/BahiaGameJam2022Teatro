using MyEvents;
using NewsSystem;
using UnityEngine;

namespace UI
{
    public class GameplayUI : MonoBehaviour
    {
        public void GoRightPressed()
        {
            NewsStore.Publish<ButtonClicked>();
            NewsStore.Publish<CameraRightPressed>();
        }

        public void GoLeftPressed()
        {
            NewsStore.Publish<ButtonClicked>();
            NewsStore.Publish<CameraLeftPressed>();
        }
    }
}
