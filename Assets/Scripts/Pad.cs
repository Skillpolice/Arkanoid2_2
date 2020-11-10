using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    Ball ball;

    public bool autoPlay;
    float yPosition;
    public float maxX;


    bool idSctivePad;
    void Start()
    {
        ball = FindObjectOfType<Ball>();

        yPosition = transform.position.y; // 3апоминаем позицию для платформы по Y
        Cursor.visible = false;
    }


    void Update()
    {

        if (autoPlay)
        {
            Vector3 ballPos = ball.transform.position; //позиция мача 
            Vector3 padNewPos = new Vector3(ballPos.x, yPosition, 0); //новая позиция pad

            padNewPos.x = Mathf.Clamp(padNewPos.x, -maxX, maxX);
            transform.position = padNewPos; // Занесли координаты мыши в платфору двигаем её за мышкой
            
        }
        else
        {
            Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // находим координаты мыши в игровом экране координат
            Vector3 padNewPosition = new Vector3(mouseWorldPosition.x, yPosition, 0); //Запоминаем двиежение платформы только  по X влево вправо и всё

            padNewPosition.x = Mathf.Clamp(padNewPosition.x, -maxX, maxX);
            transform.position = padNewPosition; // Занесли координаты мыши в платфору двигаем её за мышкой
            //autoPlay = true;
        }







    }
}
