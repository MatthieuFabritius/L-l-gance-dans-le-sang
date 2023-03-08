using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0.0f, verticalInput);
        Vector3 velocity = direction.normalized * moveSpeed;
        Vector3 transformedVelocity = transform.TransformDirection(velocity);

        rb.MovePosition(transform.position + transformedVelocity * Time.deltaTime);
    }
}