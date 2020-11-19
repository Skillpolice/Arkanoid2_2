using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numOFHeaerts;

    public Image[] heaerts;
    public Sprite fullHeaert;
    public Sprite emptyHearts;

    public void Update()
    {

     

        for (int i = 0; i < heaerts.Length; i++)
        {
            if(i<health)
            {
                heaerts[i].sprite = fullHeaert;
            }
            else
            {
                heaerts[i].sprite = emptyHearts;
            }

            if(i<numOFHeaerts)
            {
                heaerts[i].enabled = true;
            }
            else
            {
                heaerts[i].enabled = false;
            }
        }
    }


}
