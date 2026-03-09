using UnityEngine;
using UnityEngine.InputSystem;
public class Move : MonoBehaviour
{
    public float velocity = 20;
    private InputAction moveAction;
    public Rigidbody rb;

    private void Awake()
    {
        moveAction = InputSystem.actions.FindAction("Walk");
    }


    private void FixedUpdate()
    {
        Walk();
    }

    private void Walk()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();
        Vector3 move = new Vector3(input.x, 0, input.y);
        rb.linearVelocity = new Vector3(move.x * velocity, rb.linearVelocity.y, move.z * velocity);
    }
}
