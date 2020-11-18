using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text healthText;
    public GameObject panelPause;
    public GameObject gameOver;

    public Pad pad;
    public Ball ball;

    int score;

    [Header("Ко-ло жизней")]
    public int lifeCount;

    [HideInInspector]
    public bool isPauseActive;

    private void Awake() // для удаления GameManagera на разных сценах
    {
        GameManager[] gameManagers = FindObjectsOfType<GameManager>();
        for (int i = 0; i < gameManagers.Length; i++)
        {
            if (gameManagers[i].gameObject != gameObject)
            {
                Destroy(gameObject);
                gameObject.SetActive(false);
                break;
            }
        }
    }

    private void Start()
    {
        scoreText.text = "000";
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPauseActive)
            {
                Time.timeScale = 2;
                isPauseActive = false;
                Cursor.visible = false;
            }
            else
            {
                Time.timeScale = 0;
                isPauseActive = true;
                Cursor.visible = true;
            }
            panelPause.SetActive(isPauseActive);
        }
    }

    public void LoseLife()
    {
        lifeCount--;
        healthText.text = "Health: " +  lifeCount.ToString();
        if (lifeCount <= 0)
        {
            isPauseActive = true;
            gameOver.SetActive(true);
            Cursor.visible = true;
        }
    }
    public void UpLife()
    {
        lifeCount++;
        healthText.text = "Health: " + lifeCount.ToString();
    }

    //добавление очков при при разрушении блока
    public void AddScore(int addscore)
    {
        score += addscore;
        scoreText.text = score.ToString();
    }


    
}
