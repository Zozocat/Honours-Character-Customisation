using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSwitch : MonoBehaviour
{

    public GameObject infoPanel;
    public GameObject facePanel;

    public GameObject shellClothes;
    public GameObject shellColours;

    public void PanelInfo()
    {
        facePanel.SetActive(false);
        infoPanel.SetActive(true);
    }

    public void PanelFace()
    {
        infoPanel.SetActive(false);
        facePanel.SetActive(true);

        if (shellClothes.activeSelf)
        {
            // Code to execute when shellClothes is active
            // For example:
            Debug.Log("shellClothes is currently active.");

            shellColours.SetActive(true);
        }
        else
        {
            shellColours.SetActive(false);
        }
    }
}

