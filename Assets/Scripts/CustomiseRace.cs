using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomiseRace : MonoBehaviour
{
    public GameObject teifling; 
    public GameObject horns;

    public void TurnOnTeifling()
    {
        teifling.SetActive(true); 
        horns.SetActive(true);
    }

    public void TurnOffTeifling()
    {
        teifling.SetActive(false);
        horns.SetActive(false); 
    }
}
