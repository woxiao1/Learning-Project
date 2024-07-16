using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScore : MonoBehaviour
{
    public TMP_Text Scoretext;
    public int score;
    public TMP_Text EndGame;
    public GameObject StopSpawn;

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
        
        if(score >=100)
        {
            EndGame.gameObject.SetActive(true);
            EndGame.text = $"You Win";
            StopSpawn.SetActive(false);
        } 

        if(score <= -50)
        {
            EndGame.gameObject.SetActive(true);
            EndGame.text = $"You Lose";
            StopSpawn.SetActive(false);
        }
    }



}
