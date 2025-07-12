using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class RotatingDoors : MonoBehaviour
{
    // 2.) napravite rotirajuca vrata koja kad dotaknu playera se prestanu vrtiti, a kad ne dotaknu playera da se nastave vrtiti

    [SerializeField] private GameObject doors;
    [SerializeField] private PlayerMovement playerMovement;

    private Coroutine coroutine;
    private bool isRotating = true;


    private void Update()
    {
       RotateDoor();
    }
    private void OnTriggerEnter(Collider other)
    {
       isRotating = false;
    }

    private void OnTriggerExit(Collider other)
    {
        isRotating=true;
    }

  private void RotateDoor()
    {
        if (isRotating)
        {
            gameObject.transform.Rotate(0, 1, 0);
        }
    }

   
}
