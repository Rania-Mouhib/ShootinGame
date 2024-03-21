using UnityEngine;
using System.Collections;

public class ObstacleMovementRight : MonoBehaviour
{
    public float moveDistance = 4f; // Distance to move right and left
    public float moveSpeed = 2f;    // Speed of movement

    private Vector3 initialPosition;
    private Vector3 targetPosition;

    void Start()
    {
        initialPosition = transform.position;
        targetPosition = initialPosition + Vector3.right * moveDistance; // Set the initial target position to the right

        // Start the movement coroutine
        StartCoroutine(MoveObstacle());
    }

    IEnumerator MoveObstacle()
    {
        while (true)
        {
            // Move towards the target position
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * moveSpeed);

            // If the obstacle has reached the target position, switch direction
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                Vector3 temp = initialPosition;
                initialPosition = targetPosition;
                targetPosition = temp;

                // Change direction
                if (targetPosition == initialPosition + Vector3.right * moveDistance)
                {
                    targetPosition = initialPosition - Vector3.right * moveDistance; // Move to the left
                }
                else
                {
                    targetPosition = initialPosition + Vector3.right * moveDistance; // Move to the right
                }
            }

            yield return null;
        }
    }
}
