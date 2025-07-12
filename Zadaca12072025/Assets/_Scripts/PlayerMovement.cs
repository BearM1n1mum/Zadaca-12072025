using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float playerMoveSpeed;
    [SerializeField] private Rigidbody playerRigidBody;


    private void FixedUpdate()
    {
        playerRigidBody.linearVelocity = Vector3.zero;
        PlayerControls();
    }

    private void PlayerControls()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Move(Vector2.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector2.right);
        }
    }

    private void Move(Vector2 direction)
    {
       direction.Normalize();
        Vector2 targetVelocity = direction * playerMoveSpeed;
        playerRigidBody.linearVelocity = Vector2.Lerp(playerRigidBody.linearVelocity, targetVelocity, 10 * Time.deltaTime);
    }
}
