using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomiseModels : MonoBehaviour
{
    public GameObject gothicClothes;
    public GameObject shellClothes;

    public GameObject gothicHair;
    public GameObject mohawkHair;

    public GameObject[] ears;
    private int currentEars;

    public GameObject[] lips;
    private int currentLips;

    public GameObject[] horns;
    private int currentHorns;

    private void Update()
    {

        for (int i = 0; i < ears.Length; i++)
        {
            if (i == currentEars)
            {
                ears[i].SetActive(true);
            }
            else
            {
                ears[i].SetActive(false);
            }
        }

        for (int i = 0; i < lips.Length; i++)
        {
            if (i == currentLips)
            {
                lips[i].SetActive(true);
            }
            else
            {
                lips[i].SetActive(false);
            }
        }

        for (int i = 0; i < horns.Length; i++)
        {
            if (i == currentHorns)
            {
                horns[i].SetActive(true);
            }
            else
            {
                horns[i].SetActive(false);
            }
        }

    }

    public void TurnOnGothic()
    {
        gothicClothes.SetActive(true);
        shellClothes.SetActive(false);
    }

    public void TurnOnShell()
    {
        shellClothes.SetActive(true);
        gothicClothes.SetActive(false);
    }
    public void TurnOffClothes()
    {
        gothicClothes.SetActive(false);
        shellClothes.SetActive(false);
    }

    public void TurnOnGothicHair()
    {
        gothicHair.SetActive(true);
        mohawkHair.SetActive(false);
    }

    public void TurnOnMohawkHair()
    {
        mohawkHair.SetActive(true);
        gothicHair.SetActive(false);
    }
    public void TurnOffHair()
    {
        gothicHair.SetActive(false);
        mohawkHair.SetActive(false);
    }

    public void SwitchEars(int desiredEarIndex)
    {
        if(desiredEarIndex >= 0 && desiredEarIndex < ears.Length)
    {
            currentEars = desiredEarIndex;
        }
    }

    public void SwitchLips(int desiredLipsIndex)
    {
        if (desiredLipsIndex >= 0 && desiredLipsIndex < lips.Length)
        {
            currentLips = desiredLipsIndex;
        }
    }

    public void SwitchHorns(int desiredHornsIndex)
    {
        if (desiredHornsIndex >= 0 && desiredHornsIndex < horns.Length)
        {
            currentHorns = desiredHornsIndex;
        }
    }

}
