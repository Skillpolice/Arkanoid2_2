using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResetLevel : MonoBehaviour
{
    public Text healthText;
    public Ball ball;


    [Header("ко-ло жизней")]
    public int lifeCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {


        lifeCount--;
        ball.isStarted = false;

        healthText.text =  " Health " +  lifeCount.ToString();
        //DontDestroyOnLoad(gameObject);

        if (lifeCount <= 0)
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index + 1);
        }

    }
}
