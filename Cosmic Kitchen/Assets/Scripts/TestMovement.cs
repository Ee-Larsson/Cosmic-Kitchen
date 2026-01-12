using UnityEngine;

public class TestMovement : MonoBehaviour
{

    [SerializeField] float speed;
    Rigidbody2D rb;
    public Animator anim;
    bool isRunning;

    Vector2 lastMoveDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        Animate();

        rb.linearVelocity = new Vector2(0, 0);

        //move up
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.linearVelocity += new Vector2(0, speed);
            
        }

        //move down
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.linearVelocity += new Vector2(0, -speed);
            
        }

        //move left
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocity += new Vector2(-speed, 0);
            
        }

        //move right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocity += new Vector2(speed, 0);
            
        }
    }

    void ProcessInput()
    {
        lastMoveDirection = rb.linearVelocity;

        if ((rb.linearVelocity.x == 0 && rb.linearVelocity.y == 0))
        {
            anim.SetBool("isRunning", false);

            // && rb.linearVelocity.x != 0 || rb.linearVelocity.y != 0

        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }


    void Animate()
    {
        anim.SetFloat("XInput", rb.linearVelocity.x);
        anim.SetFloat("YInput", rb.linearVelocity.y);

        anim.SetFloat("XLastInput", lastMoveDirection.x);
        anim.SetFloat("YLastInput", lastMoveDirection.y);
    }
}
