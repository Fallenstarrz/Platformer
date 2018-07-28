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

    // Called after each frame, but before next one begins
    void LateUpdate ()
    {
        if (player == null)
        {
            if (GameManager.instance.player != null)
            {
                player = GameManager.instance.player.gameObject.transform;
            }
        }
        if (player != null)
        {
            transform.position = player.position + offset;
        }
	}
}
