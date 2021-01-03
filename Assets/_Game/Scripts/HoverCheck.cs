using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverCheck : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject ob;

    public void OnPointerEnter(PointerEventData eventData)
    {
        ob.GetComponent<MovementHandler>().openPanel();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ob.GetComponent<MovementHandler>().closePanel();
    }
}
