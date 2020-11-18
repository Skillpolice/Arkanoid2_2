using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int blocksCountRed;
    int index;
    private void Start()
    {
        //Block_Red[] blockRed = FindObjectsOfType<Block_Red>(); //найти все обьекты у которых есть тип block
        //Block_Blue[] blockBlue = FindObjectsOfType<Block_Blue>();
        ////Romb[] rombs = FindObjectsOfType<Romb>();
        ////Rectungl[] rectungls = FindObjectsOfType<Rectungl>();

        //blocksCountBlue = blockBlue.Length; //найти сколько обьектов
        //blocksCountRed = blockRed.Length;
        //blocksCountRomb = rombs.Length;
        //blocksCountRectungl = rectungls.Length;
    }

    public void BlockCreatedRad() //считает кол-во блоков и выводит их на экран
    {
        blocksCountRed++;
    }

    public void BlockDestroyedRad()
    {
        blocksCountRed--;
        if (blocksCountRed <= 0)
        {
            index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index + 1);
           
        }
    }

    public void WonLevel()
    {
        blocksCountRed--;

    }
}
