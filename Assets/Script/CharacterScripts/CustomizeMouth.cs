using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This class allows the player to change their character's mouth by allowing the player to go through an array of
 mouths they can choose from.*/
public class CustomizeMouth : MonoBehaviour
{
    public GameObject[] MouthType;
    public int currentMT;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < MouthType.Length-1; i++)
        {
            if (i == currentMT)
            {
                MouthType[i].SetActive(true); 
            }
            else
            {
                MouthType[i].SetActive(false); //hides the other options
            }
        }
    }

    public void ChangeMouthsRight()
    {
        if (currentMT + 1 > MouthType.Length - 1) //checks to see if there is an index ahead of it
        {
            currentMT = 0;
        }
        else
        {
            currentMT++;
        }
    }

    public void ChangeMouthsLeft()
    {
        if (currentMT - 1 < 0)
        {
            currentMT = MouthType.Length - 1;
        }
        else
        {
            currentMT--;
        }
    }
}
