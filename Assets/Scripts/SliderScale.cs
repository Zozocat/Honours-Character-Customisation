using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScale : MonoBehaviour
{
    public GameObject objectToScale;
    public Slider scaleSlider;
    private Vector3 initialScale;
    private float initialBottomY;

    private void Start()
    {
        // Store the initial scale and bottom Y position of the object
        initialScale = objectToScale.transform.localScale;
        initialBottomY = GetBottomY(objectToScale);

        // Subscribe to the OnValueChanged event of the slider
        scaleSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        // Scales object
        objectToScale.transform.localScale = new Vector3(value, value, value);

        float currentBottomY = GetBottomY(objectToScale);
        float offsetY = initialBottomY - currentBottomY;

        // Apply the offset to maintain the bottom position
        objectToScale.transform.position += Vector3.up * offsetY;
    }

    private float GetBottomY(GameObject obj)
    {
        // Calculate the minimum Y coordinate of the object's bounding box
        Renderer renderer = obj.GetComponent<Renderer>();
        Bounds bounds = renderer.bounds;
        return bounds.min.y;
    }
}