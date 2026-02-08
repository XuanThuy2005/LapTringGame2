using UnityEngine;

public class Conveyor : MonoBehaviour
{
    public float speed = 3f;

    void OnCollisionStay(Collision other)
    {
        Rigidbody rb = other.rigidbody;
        if (rb != null)
        {
            rb.AddForce(transform.right * speed, ForceMode.VelocityChange);
        }
    }
}
