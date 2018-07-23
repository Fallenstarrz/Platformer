using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (GameManager.instance.lastCheckpoint != this.gameObject.transform.position)
        {
            anim.Play("CheckpointInnactive");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("Player"))
        {
                GameManager.instance.lastCheckpoint = this.gameObject.transform.position;
                anim.Play("CheckpointActive");
        }
    }
}
