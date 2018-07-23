using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Static instance
    public static GameManager instance;

    // Hold all the string functions
    public SceneSwitcher sceneScript;

    // Variables to reset on load
    public Vector3 lastCheckpoint;
    public int score;

    // References to Actors
    public Controller_Player player;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        sceneScript = GetComponent<SceneSwitcher>();
    }

    private void Start()
    {
       // sceneScript.LoadMainMenu();
    }
}
