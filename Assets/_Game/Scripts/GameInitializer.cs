using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInitializer : MonoBehaviour
{
    public IntValue followers, funds, subscribers;
    public BoolValue u1, u2, u3, u4, u5, u6, u7;
    public void GameInitialize()
    {
        followers.value = 0;
        funds.value = 100;
        subscribers.value = 0;
        u1.bought = false;
        u2.bought = false;
        u3.bought = false;
        u4.bought = false;
        u5.bought = false;
        u6.bought = false;
        u7.bought = false;
    }
}
