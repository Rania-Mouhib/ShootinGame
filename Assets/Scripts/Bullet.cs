using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 50f;

    private void Start()
    {
        // Apply upward force to the bullet
        GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the bullet collided with the ball
        if (collision.CompareTag("Ball"))
        {
            // Destroy the collided GameObject
            Destroy(collision.gameObject);

            // Destroy the bullet itself
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            // Destroy the bullet upon contact with the ground
            Destroy(gameObject);
        }
    }
}
