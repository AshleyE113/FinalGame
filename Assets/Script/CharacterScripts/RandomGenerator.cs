using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This generates the random values for the customizer when the player hits the button.*/
public class RandomGenerator : MonoBehaviour
{
    [SerializeField] CustomizeHair hairOption;
    [SerializeField] CustomizeEyes eyesOption;
    [SerializeField] CustomizeMouth mouthOption;
    [SerializeField] CustomizeSkin skinOption;

    public void OnButtonDown()
    {
        eyesOption.currentET = Random.Range(0, eyesOption.EyeType.Length-1);
        hairOption.currentHC = Random.Range(0, hairOption.HairColor.Length - 1);
        hairOption.currentHS = Random.Range(0, hairOption.HairStyle.Length - 1);
        skinOption.currentSC = Random.Range(0, skinOption.SkinColor.Length - 1);
        mouthOption.currentMT = Random.Range(0, mouthOption.MouthType.Length - 1);
    }
}
