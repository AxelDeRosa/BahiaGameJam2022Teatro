using MyEvents;
using NewsSystem;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    [SerializeField] private Canvas[] rooms;
    private int current = 1;

    void Start()
    {
        NewsStore.Subscribe<CameraLeftPressed>(LeftArrow);
        NewsStore.Subscribe<CameraRightPressed>(RightArrow);
    }

    private void RightArrow(CameraRightPressed obj)
    {
        var prev = rooms[current++].sortingOrder =0;
        var next = rooms[current].sortingOrder =1;;
    }

    private void LeftArrow(CameraLeftPressed obj)
    {
        var prev = rooms[current--].sortingOrder =0;
        var next = rooms[current].sortingOrder =1;;
    }
}