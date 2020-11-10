using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Ссылка на обьект 
    public Rigidbody2D rb; // доступ к обьекту из unity // и перетаскиваем обьект (скрипт мяча) на обьект в Unity , что бы получить его же Rigidbody
    Pad pad; //ссылка(скрипт) на платформу, что бы мячь ездил вместе с платформой

    public float speedBall;
    bool isStarted;

    private void Start()
    {
        pad = FindObjectOfType<Pad>();
    }


    private void Update()
    {


        if (isStarted)
        {

        }
        else
        {
            Vector3 padPosition = pad.transform.position; //позиция платформы 
            float yPosBall = transform.position.y;
            Vector3 ballNewPosition = new Vector3(padPosition.x, yPosBall, 0); //новая позиция меча
            transform.position = ballNewPosition;

            if (Input.GetMouseButtonDown(0)) //нажатие мыши left для полета меча
            {
                StarBall();
                return;
            }
        }
    }

    private void StarBall() //
    {
        float randX = Random.Range(-5f, 5f);
        Vector2 force = new Vector2(randX, 5).normalized * speedBall;
        rb.AddForce(force);   //создаем дивежие меча по координатам через AddForce
        isStarted = true;
    }


}
