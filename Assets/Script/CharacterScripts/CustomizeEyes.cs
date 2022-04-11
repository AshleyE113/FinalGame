using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This class allows the player to change their character's eyes by allowing the player to go through an array of
 eyes they can choose from.*/
public class CustomizeEyes : MonoBehaviour
{

    public GameObject[] EyeType;
    public int currentET;
    
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < EyeType.Length; i++)
        {
            if (i == currentET)
            {
                EyeType[i].SetActive(true);
            }
            else
            {
                EyeType[i].SetActive(false);
            }
        }
    }

    public void ChangeEyesRight()
    {
        if (currentET + 1 > EyeType.Length-1)
        {
            currentET = 0;
        }
        else
        {
            currentET++;
        }
    }

    public void ChangeEyesLeft()
    {
        if (currentET - 1 < 0)
        {
            currentET = EyeType.Length-1;
        }
        else
        {
            currentET--;
        }
    }
}
