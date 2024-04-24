using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private Slider slider; 
    [SerializeField] private Transform cameraTransform;

    [SerializeField] private float zRange = -1.1f; 
    [SerializeField] private float yRange = 0.45f;

    private Vector3 initialCameraPosition;

    private void Start()
    {
        initialCameraPosition = cameraTransform.position;
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        // Map the slider value to the desired Z and Y positions
        float zPosition = Mathf.Lerp(initialCameraPosition.z, initialCameraPosition.z + zRange, slider.normalizedValue);
        float yPosition = Mathf.Lerp(initialCameraPosition.y, initialCameraPosition.y + yRange, slider.normalizedValue);

        // Update the camera's position
        Vector3 newPosition = new Vector3(cameraTransform.position.x, yPosition, zPosition);
        cameraTransform.position = newPosition;
    }
}
