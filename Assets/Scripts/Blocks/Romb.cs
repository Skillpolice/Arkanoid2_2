using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Romb : MonoBehaviour
{
    GameManager gameManager; //ссылка на обьект блокаБ что он мог подсчитать каждый разбитый блок
    LevelManager levelManager;

    [Tooltip("Кол-во очков")] public int points;

    

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); //нати обьект у которого есть ссылка GameManager  и полжить в переменную gameMaanger
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.BlockCreatedRad();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.AddScore(points); //добавление очков при разрушении блока
        levelManager.BlockCreatedRad();
        Destroy(gameObject);
    }
}
