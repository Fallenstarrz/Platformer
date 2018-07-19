using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    // Use this for initialization
    void Start ()
    {
        offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (player != null)
        {
            transform.position = player.position + offset;
        }
	}
}
