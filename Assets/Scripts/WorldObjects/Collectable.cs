﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int scoreToAdd;
    public AudioClip pickUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == GameManager.instance.player.gameObject)
        {
            GameManager.instance.score += scoreToAdd;
            // Add GUI popup that stays for 1s that displays the score
            Destroy(this.gameObject);
        }
    }
    // Make GUI pop up in world space at the location of the pickup

    private void OnDestroy()
    {
        AudioSource.PlayClipAtPoint(pickUp, transform.position, 2);
    }
}
