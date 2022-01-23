using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{

    [SerializeField]
    private float moveForce = 15f, jumpForce = 500f;

    private float movementX;

    private Rigidbody2D Body;

    private SpriteRenderer sr;
    private Animator anim;
    private bool isGrounded;

    private double v,tot;
    // Start is called before the first frame update
    private void Awake()
    {

        sr = GetComponent<SpriteRenderer>();
        Body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
        Anim();
        PlayerJump();

    }


    void Anim()
    {
        if (movementX > 0)
        {
            anim.SetBool("Walk", true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            // we are going to the left side
            anim.SetBool("Walk", true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool("Walk", false);
        }

    }

    void PlayerMovement()
    {
        v = transform.position.x;
        
        movementX = Input.GetAxisRaw("Horizontal");
        tot = v + movementX;
        if (tot < 77 && tot > -57){
            transform.position += new Vector3(movementX, 0f, 0f) * moveForce * Time.deltaTime;
        }
    }

    void PlayerJump()
    {

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            Body.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

        }


}
