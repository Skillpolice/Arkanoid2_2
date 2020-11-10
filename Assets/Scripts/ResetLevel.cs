using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevel : MonoBehaviour
{
    public Ball ball;
    public Pad pad;
     

    bool isfalen;

    [Header("ко-ло жизней")]
    public int lifeCount;

    private void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {


        //если шар уже дотронулся то нижней платформы, то уже надо вернуть шар на место, не надо делать проверку на -4,7

        Vector3 padPosition = pad.transform.position; //позиция платформы 
        float yPosBall = transform.position.y;

        if (isfalen == collision)
        {
            
            lifeCount--;
            Vector3 ballNewPosition = new Vector3(padPosition.x, yPosBall, 0); //новая позиция меча
            transform.position = ballNewPosition;
            isfalen = true;
        }
        else
        {
           
            lifeCount--;
            if (lifeCount <= 0)
            {
                SceneManager.LoadScene(0);
            }
        }



    }
}
