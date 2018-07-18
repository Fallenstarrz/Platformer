using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player : Controller {

	// Use this for initialization
	protected override void Start ()
    {
		
	}
	
	// Update is called once per frame
	protected override void Update ()
    {
        inputHandler();
	}

    void inputHandler()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // Move left
            // Flip left
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Move right
            // flip right
        }
        if (Input.GetKey(KeyCode.W))
        {
            // Climb
        }
        if (Input.GetKey(KeyCode.S))
        {
            // Crouch
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
