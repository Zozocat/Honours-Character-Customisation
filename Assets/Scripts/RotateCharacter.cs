using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateCharacter : MonoBehaviour
{
    public Slider rotationSlider; 
    private float previousSliderValue; 

    private void Start()
    {
        previousSliderValue = rotationSlider.value;
    }

    private void Update()
    {
        if (rotationSlider.value != previousSliderValue)
        {
            float rotationAngle = rotationSlider.value * 360f;
            transform.rotation = Quaternion.Euler(0f, rotationAngle, 0f);
            previousSliderValue = rotationSlider.value;
        }
    }
}
