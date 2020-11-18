﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupAgro : MonoBehaviour
{
    private void ApplyEffect()
    {
        Ball ball = FindObjectOfType<Ball>();
        ball.RestartBall();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pad"))
        {
            //TODO применение эффекта
            //вызов функции 

            ApplyEffect();
            Destroy(gameObject);
        }


    }
}
