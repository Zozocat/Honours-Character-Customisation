using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraSwitch : MonoBehaviour
{
    public Camera[] cameras;

    private int currentCameraIndex = 0;

    public UnityEngine.UI.Button switchButton;

    private void Start()
    {
        switchButton.onClick.AddListener(OnSwitchButtonClick);
    }

    private void OnSwitchButtonClick()
    {
        SwitchCamera();
    }

    public void SwitchCamera()
    {
        Debug.Log("Camera Swap");

        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

        foreach (Camera cam in cameras)
        {
            cam.enabled = false;
        }

        cameras[currentCameraIndex].enabled = true;
    }
}
