﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class InvisibleBloc : MonoBehaviour
{
    [Header("Managers")]
    GameManager gameManager; //ссылка на обьект блокаБ что он мог подсчитать каждый разбитый блок
    LevelManager levelManager;

    public SpriteRenderer spriteRenderer;

    public int points;
    public int blockHealth;
    public int invblock;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); //нати обьект у которого есть ссылка GameManager  и полжить в переменную gameMaanger
        levelManager = FindObjectOfType<LevelManager>();
        levelManager.BlockCreatedRad();
        spriteRenderer.GetComponent<SpriteRenderer>(); // GetComponent - ищет компонент на котором весит скрипт обьекта
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        invblock--;
        if (invblock == 1) ////отображение невидимого блока
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }

        blockHealth--;
        if (blockHealth <= 0)
        {
            gameManager.AddScore(points); //добавление очков при разрушении блока
            levelManager.BlockCreatedRad();

            Destroy(gameObject);
        }
    }



}
