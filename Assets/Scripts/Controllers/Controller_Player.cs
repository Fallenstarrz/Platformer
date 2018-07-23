using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player : Controller
{
    // Components
    public Transform tf;
    public SpriteRenderer sprite;
    public Rigidbody2D rb;
    public PolygonCollider2D hitBox;
    public AudioSource soundMaker;
    public Animator anim;

    //Sounds
    public AudioClip dashSound;
    public AudioClip JumpSound;
    public AudioClip PickUpSound;
    public float soundVolume;

    // Movement Variables
    public float moveSpeed;
    // Add some form of sprint using left shift.
    public float jumpForce;
    public float dashDistance;
    public bool isDashing;
    public bool isInAir;
    public int jumpCountCurrent = 1;
    public int jumpCountMax;
    public float distanceToFeet;
    public bool isMoving;

    RaycastHit2D ground;

    // Use this for initialization
    protected override void Start ()
    {
        tf = GetComponent<Transform>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        hitBox = GetComponent<PolygonCollider2D>();
        soundMaker = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	protected override void Update ()
    {
        inputHandler();
	}

    void inputHandler()
    {
        // Idle
        if (!isInAir && !isMoving)
        {
            anim.Play("Idle");
        }

        // Movement
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            isMoving = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            isMoving = true;
            tf.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            sprite.flipX = true;
            if (!isInAir)
            {
                anim.Play("PlayerRun");
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            isMoving = true;
            tf.Translate(moveSpeed * Time.deltaTime, 0, 0);
            sprite.flipX = false;
            if (!isInAir)
            {
                anim.Play("PlayerRun");
            }
        }

        // Jumping
        ground = Physics2D.Raycast(tf.position, Vector2.down, distanceToFeet);
        Debug.DrawRay(tf.position, Vector2.down * distanceToFeet, Color.red);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpCountCurrent < jumpCountMax)
            {
                jumpCountCurrent++;
                rb.AddForce(Vector3.up * jumpForce);
                soundMaker.PlayOneShot(JumpSound, soundVolume);
            }
        }
        if (ground.collider != null)
        {
            isInAir = false;
            jumpCountCurrent = 1;
        }
        else
        {
            isInAir = true;
        }
        if (rb.velocity.y > 0)
        {
            anim.Play("PlayerJump");
        }
        else if (rb.velocity.y < 0)
        {
            anim.Play("PlayerFall");
        }

        // Planned Features!
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Open in game menu
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Dash
        }
        if (Input.GetKey(KeyCode.F))
        {
            // Interact
        }
        if (Input.GetKey(KeyCode.W))
        {
            // Climb
        }
        if (Input.GetKey(KeyCode.S))
        {
            // Crouch or climb down
        }
    }
}
