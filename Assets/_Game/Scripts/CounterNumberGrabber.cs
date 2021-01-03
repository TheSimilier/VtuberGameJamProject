using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CounterNumberGrabber : MonoBehaviour
{
    private TextMeshProUGUI textOutput;

    public IntValue input;

    private void Start()
    {
        textOutput = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        textOutput.text = input.value.ToString();
    }
}
