using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShootManager : MonoBehaviour
{
    //Score Variables
    public int score;
    public TMP_Text scoreText;
    
    //Timer Variables
    public TMP_Text countdownText;
    public float timeRemaining;
    private bool timerCountdown, timerGame = false;

    public GameObject appManager;

    void Start()
    {
        score = 0; //resets score
        scoreText.SetText("Score: " + score.ToString());
        timerCountdown = true;
        timeRemaining = 3;
    }

    void Update()
    {
        if (timerCountdown)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                countdownText.SetText(Mathf.Ceil(timeRemaining).ToString());
            }
            else
            {
                timeRemaining = 0;
                timerCountdown = false;
                timerGame = true;
                timeRemaining = 10;
            }
        }
        if (timerGame)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                countdownText.SetText(Mathf.Ceil(timeRemaining).ToString());
            }
            else
            {
                timeRemaining = 0;
                timerCountdown = false;
                appManager.GetComponent<AppleSpawner>().AppleShutDown();
            }
        }
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
