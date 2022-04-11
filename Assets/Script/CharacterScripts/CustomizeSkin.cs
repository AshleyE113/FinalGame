using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This class allows the player to change their character's skin color. It accesses the character's material and allows the player to go through an array of
 set colors so they can choose a skin color.*/

public class CustomizeSkin : MonoBehaviour
{
    public Color[] SkinColor;
    public Material charMaterial;
    public int currentSC;

    void Update()
    {
        for (int i = 0; i < SkinColor.Length - 1; i++)
        {
            if (i == currentSC)
            {
                charMaterial.color = SkinColor[i];
            }
        }
    }
    
    public void ChangeColorRight()
    {
        if (currentSC + 1 > SkinColor.Length - 1) //if it's at the end of the array, go back to 0
        {
            currentSC = 0;
        }
        else
        {
            currentSC++;
        }
    }

    public void ChangeColorLeft()
    {
        if (currentSC - 1 < 0) 
        {
            currentSC = SkinColor.Length - 1; //if it's outside of the array, set it back to the end
        }
        else
        {
            currentSC--;
        }
    }
}
