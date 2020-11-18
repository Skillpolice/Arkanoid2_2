using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rectungl : MonoBehaviour
{
    GameManager gameManager; //ссылка на обьект блокаБ что он мог подсчитать каждый разбитый блок
    LevelManager levelManager;
    SpriteRenderer spriteRenderer;


    public GameObject particalEffects;
    public GameObject pickupPrefab;
    public Sprite[] sprite;
   

    [Tooltip("Кол-во очков")] public int points;
    [Tooltip("Кол-во жизней")] public int blockHealth;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); //нати обьект у которого есть ссылка GameManager  и полжить в переменную gameMaanger
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.BlockCreatedRad();
        spriteRenderer = GetComponent<SpriteRenderer>();
       
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        blockHealth--;
        for (int i = 0; i < sprite.Length; i++)
        {
            spriteRenderer.sprite = sprite[i];
            i++;
        }


        if (blockHealth <= 0)
        {
            gameManager.AddScore(points); //добавление очков при разрушении блока
            levelManager.BlockDestroyedRad();
            Instantiate(pickupPrefab, transform.position, Quaternion.identity);
            Instantiate(particalEffects, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
       

    }
  
}
