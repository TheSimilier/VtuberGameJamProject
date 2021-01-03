using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class MovementHandler : MonoBehaviour
{
    public RectTransform panel;
    public int open, closed;
    public bool vertical;

    private void Start()
    {
        if(!vertical)
        {
            panel.DOMoveX(closed, 1f);
        }
        else
        {
            panel.DOMoveY(closed, 1f);
        }
    }

    public void openPanel()
    {
        if (!vertical)
        {
            panel.DOMoveX(open, 1f);
        }
        else
        {
            panel.DOMoveY(open, 1f);
        }
    }

    public void closePanel()
    {
        if (!vertical)
        {
            panel.DOMoveX(closed, 1f);
        }
        else
        {
            panel.DOMoveY(closed, 1f);
        }
    }
}
