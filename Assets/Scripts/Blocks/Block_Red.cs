using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block_Red : MonoBehaviour
{
    public Sprite sprite;

    [Tooltip("Кол-во очков")] public int points;

    GameManager gameManager; //ссылка на обьект блока, что он мог подсчитать каждый разбитый блок
    LevelManager levelManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); //нати обьект у которого есть ссылка GameManager  и полжить в переменную gameMaanger
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.BlockCreatedRad();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.AddScore(points); //добавление очков при разрушении блока
        levelManager.BlockDestroyedRad(); //считает сколько блоков уничтожено и переводит на след. уровень
        Destroy(gameObject);
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
       if(levelManager.blocksCountRed <=0)
        {
            
        }
    }
}
