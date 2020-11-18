using UnityEngine;
 
public class ResetLevel : MonoBehaviour
{
    GameManager gameManager;
    Ball ball;
    public GameObject particalEffects;
    int lifeCount;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); //нахождение других перенных - методов других скриптов
        ball = FindObjectOfType<Ball>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ball")) //если тег совпадает с названием выполняем код ниже
        {
            //если мяч - отнять жизнь
            gameManager.LoseLife();
            ball.RestartBall();
            Instantiate(particalEffects, transform.position, Quaternion.identity);
        }
        else
        {
            //если не мяч - уничтожить обьект
            Destroy(collision.gameObject);
        }

        
    }

    

   
}
