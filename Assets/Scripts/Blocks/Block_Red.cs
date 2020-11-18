using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Block_Red : MonoBehaviour
{
    [Tooltip("Кол-во очков")] public int points;

    GameManager gameManager; //ссылка на обьект блока, что он мог подсчитать каждый разбитый блок
    LevelManager levelManager;
    public GameObject pickupPrefab;
    public GameObject particalEffects;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); //нати обьект у которого есть ссылка GameManager  и полжить в переменную gameMaanger
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.BlockCreatedRad();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }
    public void DestroyBlock()
    {
        gameManager.AddScore(points); //добавление очков при разрушении блока
        levelManager.BlockDestroyedRad(); //считает сколько блоков уничтожено и переводит на след. уровень
        Destroy(gameObject);

       
        Instantiate(pickupPrefab,transform.position,Quaternion.identity); //создать обьект на основе прифаба
        Instantiate(particalEffects, transform.position, Quaternion.identity);
    }


}
