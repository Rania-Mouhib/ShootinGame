using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public CountdownTimer countdownTimer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Check if the collision is with the player
        {
            countdownTimer.GameOver();
        }
    }
}
