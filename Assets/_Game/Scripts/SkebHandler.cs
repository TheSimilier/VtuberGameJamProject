using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkebHandler : MonoBehaviour
{
    public IntValue followers, subs, funds;
    public int price;

    public void onClick()
    {
        if (funds.value > price)
        {
            funds.value = funds.value - price;

            followers.value = followers.value + Random.Range(1, price);
            subs.value = subs.value + Random.Range(1, price / 2);
        }
    }
}
