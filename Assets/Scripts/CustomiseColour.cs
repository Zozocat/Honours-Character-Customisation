using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomiseColour : MonoBehaviour
{
   
    public Color[] bodyColours;
    public Material bodyMat;

    public Color[] HairColours;
    public Material hairMat;

    public Color[] EyebrowColours;
    public Material eyebrowMat;

    public Color[] LipColours;
    public Material lipMat;

    public Color[] ShellSuitColours;
    public Material shellsuitMat;

    public void ChangeSkinColour(int colourIndex)
    { 
        bodyMat.color = bodyColours[colourIndex];
    }

    public void ChangeHairColour(int colourIndex)
    {
        hairMat.color = HairColours[colourIndex];
    }

    public void ChangeBrowColour(int colourIndex)
    {
        eyebrowMat.color = EyebrowColours[colourIndex];
    }

    public void ChangeLipColour(int colourIndex)
    {
        lipMat.color = LipColours[colourIndex];
    }

    public void ChangeShellSuitColour(int colourIndex)
    {
        shellsuitMat.color = ShellSuitColours[colourIndex];
    }
}
