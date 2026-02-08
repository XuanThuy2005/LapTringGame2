using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Đụng vật cản thật
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Va chạm với: " + collision.gameObject.name);
    }

    // Đi vào trigger
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger với: " + other.gameObject.name);

        // ví dụ: nhặt coin thì xóa luôn
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
