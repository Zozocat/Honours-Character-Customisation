using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainToProfile : MonoBehaviour
{
    public GameObject objectToDisable;
    public GameObject objectToEnable;

    public void ToggleObjectsState()
    {
        // Toggle the active state of the objects
        objectToDisable.SetActive(!objectToDisable.activeSelf);
        objectToEnable.SetActive(!objectToEnable.activeSelf);
    }
}