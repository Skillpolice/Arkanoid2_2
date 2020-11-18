using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBallSize : MonoBehaviour
{
    float yPosition;
    void Start()
    {
        yPosition = transform.position.x;
    }

    private void ApplyEffect()
    {
        Ball ball = FindObjectOfType<Ball>();
        float randX = Random.Range(0.2f, 2f);
        ball.transform.localScale = new Vector3(randX, randX); //Изменение размера мача

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
