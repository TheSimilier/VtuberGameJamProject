using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePurchaseHandler : MonoBehaviour
{
    public IntValue funds;
    public BoolValue purchaseState;
    public int price;

    public void purchase()
    {
        if(funds.value > price)
        {
            funds.value = funds.value - price;
            purchaseState.bought = true;
        }
    }
}
