using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public float speed = 100;
    public float jumpSpeed = 15;
    bool isGrounded;
    bool canDoubleJump;
    public float delayBeforeDoubleJump;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
 
        moveLeft = false;
        moveRight = false;
    }
 
    //I am pressing the left button
    public void PointerDownLeft()
    {
        moveLeft = true;
    }
 
    //I am not pressing the left button
    public void PointerUpLeft()
    {
        moveLeft = false;
    }
 
    //Same thing with the right button
    public void PointerDownRight()
    {
        moveRight = true;
    }
 
    public void PointerUpRight()
    {
        moveRight = false;
    }
 
    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }
 
    //Now let's add the code for moving
    private void MovementPlayer()
    {
        //If I press the left button
        if (moveLeft)
        {
            horizontalMove = -speed;
        }
 
        //if i press the right button
        else if (moveRight)
        {
            horizontalMove = speed;
        }
 
        //if I am not pressing any button
        else
        {
            horizontalMove = 0;
        }
    }
 
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = true;
            canDoubleJump = false;
        }
    }
    public void jumpButton()
    {
        if(isGrounded)
        {
            isGrounded = false;
            rb.velocity = Vector2.up * (jumpSpeed+10);
            Invoke("EnableDoubleJump", delayBeforeDoubleJump);
        }
        if (canDoubleJump)
        {
            rb.velocity = Vector2.up * (jumpSpeed+10);
            canDoubleJump = false;
        }
    }
 
    void EnableDoubleJump()
        {
            canDoubleJump = true;
        }
 
    //add the movement force to the player
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }
}
