using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spee : MonoBehaviour
{
    GameManager gameManager;
    Ball ball;
    Pad pad;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        ball = FindObjectOfType<Ball>();
        pad = FindObjectOfType<Pad>();
    }

    public void SpeedTestX1()
    {

        if (gameManager.isPauseActive)
        {
            Time.timeScale = 1;
            ball.StartBall();
            pad.autoPlay = true;
            gameManager.isPauseActive = false;
            gameManager.Update();
        }
        gameManager.panelPause.SetActive(gameManager.isPauseActive);

    }
    public void SpeedTestX2()
    {

        if (gameManager.isPauseActive)
        {
            Time.timeScale = 2;
            pad.autoPlay = true;
            ball.StartBall();
            gameManager.isPauseActive = false;
        }
        gameManager.Update();
        gameManager.panelPause.SetActive(gameManager.isPauseActive);
    }
    public void SpeedTestX3()
    {

        if (gameManager.isPauseActive)
        {
            Time.timeScale = 3;
            pad.autoPlay = true;
            ball.StartBall();
            gameManager.isPauseActive = false;
        }
        gameManager.Update();
        gameManager.panelPause.SetActive(gameManager.isPauseActive);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        if (gameManager.isPauseActive)
        {
            gameManager.panelPause.SetActive(true);
        }

        gameManager.lifeCount = 3;
        gameManager.healthText.text = "Health: " + gameManager.lifeCount.ToString();
        gameManager.score = 0;
        gameManager.scoreText.text = "Points: 000";
        return;
    }

}
