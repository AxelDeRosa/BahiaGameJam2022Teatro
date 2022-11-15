using MyEvents;
using NewsSystem;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    [SerializeField] private GameObject[] rooms;
    private int current = 1;
    void Start()
    {
        NewsStore.Subscribe<CameraLeftPressed>(LeftArrow);
        NewsStore.Subscribe<CameraRightPressed>(RightArrow);
    }

    private void RightArrow(CameraRightPressed obj)
    {
        rooms[current++].SetActive(false);
        rooms[current].SetActive(true);
    }

    private void LeftArrow(CameraLeftPressed obj)
    {
        rooms[current--].SetActive(false);
        rooms[current].SetActive(true);
    }

    
}
