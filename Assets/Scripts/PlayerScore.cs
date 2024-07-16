using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScore : MonoBehaviour
{
    public TMP_Text Scoretext;
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        score += 1;
        Scoretext.text = $"Score : {score}";

        Destroy(other.gameObject);
    }



}
