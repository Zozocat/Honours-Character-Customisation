using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPosition : MonoBehaviour
{
    public GameObject objectToPos;
    public Slider posSlider;

    private void Start()
    {
        posSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        objectToPos.transform.localPosition = new Vector3(objectToPos.transform.localPosition.x, objectToPos.transform.localPosition.y, value);
    }
}