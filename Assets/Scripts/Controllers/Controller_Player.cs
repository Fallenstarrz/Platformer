using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player : MonoBehaviour
{
    // Components
    public Transform tf;
    public SpriteRenderer sprite;
    public Rigidbody2D rb;
    public CapsuleCollider2D hitBox;
    public AudioSource soundMaker;

    // Movement Variables
    public float moveSpeed;
    public float jumpForce;
    public float dashDistance;
    public bool isDashing;
    public bool isJumping;
    public int jumpCount;

	// Use this for initialization
	void Start ()
    {
        tf = GetComponent<Transform>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        hitBox = GetComponent<CapsuleCollider2D>();
        soundMaker = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        inputHandler();
	}

    void inputHandler()
    {
        if (Input.GetKey(KeyCode.A))
        {
            tf.Translate(-moveSpeed * Time.deltaTime,0,0);
            sprite.flipX = true;
            // Flip left
        }
        if (Input.GetKey(KeyCode.D))
        {
            tf.Translate(moveSpeed * Time.deltaTime, 0, 0);
            sprite.flipX = false;
            // flip right
        }
        if (Input.GetKey(KeyCode.W))
        {
            // Climb
        }
        if (Input.GetKey(KeyCode.S))
        {
            // Crouch or climb down
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Jump
        }
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
    }
}
