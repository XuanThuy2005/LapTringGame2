using UnityEngine;

public class PlayerMove3D : MonoBehaviour
{
    public float force = 10f;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(h, 0, v) * force);
    }
}
