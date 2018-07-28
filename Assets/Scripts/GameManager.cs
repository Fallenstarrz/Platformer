using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Static instance
    public static GameManager instance;

    // Hold all the string functions
    public SceneSwitcher sceneScript;

    // Variables
    public Vector3 lastCheckpoint;
    public int score;
    public int playerLives;

    // References to Actors
    public Controller_Player player;
    public GameObject playerPrefab;

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

    private void Update()
    {
        if (player == null)
        {
            if (playerLives > 0)
            {
                playerRespawn();
            }
            else
            {
                // Open You Lose Scene
            }
        }
    }

    private void playerRespawn()
    {
        playerLives -= 1;
        Instantiate(playerPrefab, lastCheckpoint, Quaternion.Euler (0,0,0));
    }
}
