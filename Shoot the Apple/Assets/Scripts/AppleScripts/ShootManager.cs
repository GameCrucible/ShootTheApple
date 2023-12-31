using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShootManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    void Start()
    {
        score = 0; //resets score
        scoreText.SetText("Score: " + score.ToString());
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.SetText("Score: " + score.ToString());
    }

    public void DecreaseScore()
    {
        if (score <= 0)
        {
            score = 0;
            scoreText.SetText("Score: " + score.ToString());
        }
        else{
            score--;
            scoreText.SetText("Score: " + score.ToString());
        }
        
    }
}
