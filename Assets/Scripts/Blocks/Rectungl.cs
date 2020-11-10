using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rectungl : MonoBehaviour
{
    GameManager gameManager; //ссылка на обьект блокаБ что он мог подсчитать каждый разбитый блок
    LevelManager levelManager;
    public Sprite sprite;

    [Tooltip("Кол-во очков")] public int points;
    [Tooltip("Кол-во жизней")] public int blockHealth;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); //нати обьект у которого есть ссылка GameManager  и полжить в переменную gameMaanger
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.BlockCreatedRad();


     
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        blockHealth--;
        if (blockHealth <= 0)
        {
            gameManager.AddScore(points); //добавление очков при разрушении блока
            levelManager.BlockCreatedRad();

            Destroy(gameObject);
        }


    }
    //private void OnCollisionExit2D(Collision2D collision)
    //{
     


    //    for (int i = 0; i > levelManager.blocksCountRed; i--)
    //    {
    //        if (levelManager.blocksCountRed <= 1)
    //        {
                
    //        }
    //    }
    //}
}
