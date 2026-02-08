using UnityEngine;

public class PushObject : MonoBehaviour
{
    public float force = 500f;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.forward * force);
        }
    }
}
