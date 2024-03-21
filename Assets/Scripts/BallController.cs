using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 2000;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(20 * Time.deltaTime * speed, 20 * Time.deltaTime * speed));
    }
   
}
