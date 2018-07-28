using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public SceneSwitcher sceneSwitcher;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == GameManager.instance.player.gameObject)
        {

        }
    }
}
