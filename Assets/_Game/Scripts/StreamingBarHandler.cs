using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StreamingBarHandler : MonoBehaviour
{
    public GameObject ob, btn;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        ob.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value == 1)
        {
            ob.SetActive(false);
            slider.GetComponent<StreamingBar>().CurrentValue = 0;
            btn.GetComponent<StreamHandler>().onClick();
        }
    }

    public void startStreaming()
    {
        ob.SetActive(true);
    }
}
