using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
    public Slider sliderInstance;

    void Start()
    {
        sliderInstance.minValue = 0;
        sliderInstance.maxValue = 100;
        sliderInstance.wholeNumbers = true;
        sliderInstance.value = 50;
    }

    public void OnValueChanged(float value)
    {
        Debug.Log($"New value: {value}");
    }
}