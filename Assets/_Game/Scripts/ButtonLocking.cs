using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLocking : MonoBehaviour
{
    public BoolValue purchased;

    // Update is called once per frame
    void Update()
    {
        if(purchased.bought)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
        else if(!purchased.bought)
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
}
