using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;
    public float gravity = -9.8f;
    public float jumpHeight = 2f;

    CharacterController controller;
    Vector3 velocity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = transform.right * h + transform.forward * v;

        if (controller.isGrounded && velocity.y < 0)
            velocity.y = -2f;

        if (Input.GetKeyDown(KeyCode.Space) && controller.isGrounded)
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

        velocity.y += gravity * Time.deltaTime;

        controller.Move((move * speed + velocity) * Time.deltaTime);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
{
    Rigidbody rb = hit.collider.attachedRigidbody;

    if (rb != null && !rb.isKinematic)
    {
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        rb.AddForce(pushDir * 3f, ForceMode.Impulse);
    }
}

}
