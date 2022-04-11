using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This class allows the player to change their character's hair and hair color. It allows the player to change the hair color by accessing the material on
 the player and allowing the player to go through an array of set colors so they can choose their hair color.*/
public class CustomizeHair : MonoBehaviour
{
    public GameObject[] HairStyle;
    public Color[] HairColor;
    public int currentHS;
    public int currentHC;
    [SerializeField] Material hairMaterial;

    void Update()
    {
        for (int i = 0; i < HairStyle.Length - 1; i++)
        {
            if (i == currentHS)
            {
                HairStyle[i].SetActive(true);
            }
            else
            {
                HairStyle[i].SetActive(false);
            }
        }

        for (int i = 0; i < HairColor.Length - 1; i++)
        {
            if (i == currentHC)
            {
                hairMaterial.color = HairColor[i];
            }
        }
    }

    public void ChangeHairRight()
    {
        if (currentHS + 1 > HairStyle.Length - 1)
        {
            currentHS = 0;
        }
        else
        {
            currentHS++;
        }
    }

    public void ChangeHairLeft()
    {
        if (currentHS - 1 < 0)
        {
            currentHS = HairStyle.Length - 1;
        }
        else
        {
            currentHS--;
        }
    }

    public void ChangeHairColorRight()
    {
        if (currentHC == HairColor.Length - 1)
        {
            currentHC = 0;
        }
        else
        {
            currentHC++;
        }
    }

    public void ChangeHairColorLeft()
    {
        if (currentHC < 0)
        {
            currentHC = HairColor.Length - 1;
        }
        else
        {
            currentHC--;
        }
    }
}
