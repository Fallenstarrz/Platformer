﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Set checkpoint animation to innactive
    private void Update()
    {
        if (GameManager.instance.lastCheckpoint != this.gameObject.transform.position)
        {
            anim.Play("CheckpointInnactive");
        }
    }
    // Set checkpoint animation to active && set the checkpoint to this position
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Player"))
        {
            GameManager.instance.lastCheckpoint = this.gameObject.transform.position;
            anim.Play("CheckpointActive");
        }
    }
}
