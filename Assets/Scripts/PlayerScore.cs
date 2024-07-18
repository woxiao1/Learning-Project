using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScore : MonoBehaviour
{
    public TMP_Text Scoretext;
    public int score;
    public TMP_Text EndGame;
    public GameObject StopSpawn;

    public SpawnManager spawnManager;

    private void Start()
    {
        EndGame.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            score += 1;
        }
        if (other.tag == "Obstacle")
        {
            score -= 1;
        }
        Scoretext.text = $"Score : {score}";

        Destroy(other.gameObject);
    }
    private void Update ()
    {
        CheckWin();
        CheckLose();
    }

    private void CheckLose()
    {
        if (score <= -50)
        {
            EndGame.gameObject.SetActive(true);
            EndGame.text = $"You Lose";

            spawnManager.StopSpawn();
        }
    }

    private void CheckWin()
    {
        if (score >= 100)
        {
            EndGame.gameObject.SetActive(true);
            EndGame.text = $"You Win";

            spawnManager.StopSpawn();
        }
    }
}
