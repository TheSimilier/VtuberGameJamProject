using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StreamingBar : MonoBehaviour
{
    public Slider slider;
    private float currentValue = 0f;
    public float CurrentValue
    {
        get { return currentValue; }
        set 
        {
            currentValue = value;
            slider.value = currentValue;
        }
    }

    private void Start()
    {
        CurrentValue = 0f;
    }

    private void Update()
    {
        CurrentValue += 0.0004f;
    }
}
