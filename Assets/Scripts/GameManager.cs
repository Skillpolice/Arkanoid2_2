using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    
    public Pad pad;

    int score;
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
                Time.timeScale = 1;    
                isPauseActive = false;
            }
            else
            {
                Time.timeScale = 0;
                isPauseActive = true;
            }
        }
    }


    public void AddScore(int addscore)
    {
        score += addscore;
        scoreText.text = score.ToString();
    }
}
