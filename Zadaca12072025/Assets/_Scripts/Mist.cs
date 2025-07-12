using UnityEngine;

public class Mist : MonoBehaviour
{
    //  1.) Napravite podrucje "magle" u koje kad player udje da mu se uspori kretanje za 20%, a kad izadje onda se nastavi kretati normalnom brzinom
    //  2.) napravite roptirajuca vrata koja kad dotaknu playera se prestanu vrtiti, a kad ne dotaknu playera da se nastave vrtiti

    [SerializeField] private GameObject mistArea;
    [SerializeField] private PlayerMovement playerMovement;

    private float playerSlowDown = 0.8f;



    private void OnTriggerEnter(Collider other)
    {
        playerMovement.playerMoveSpeed *= playerSlowDown;
        Debug.Log($"Slowed down");
    }

    private void OnTriggerExit(Collider other)
    {
        playerMovement.playerMoveSpeed /= playerSlowDown;
        Debug.Log($"Back to normal speed");
    }


}
