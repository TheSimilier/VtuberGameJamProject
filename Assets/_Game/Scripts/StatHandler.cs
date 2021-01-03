using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatHandler : MonoBehaviour
{
    public IntValue subcount, followercount, funds;
    public BoolValue emotecom, l2d1, l2d2, merch_s, merch_l, mocap, layout;
    private float gainChance;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            passiveSubscriberGain();
            passiveFollowerGain();
            passiveFundsGain();
        }
    }

    void passiveSubscriberGain()
    {
        gainChance = (subcount.value / 100) + (followercount.value / 100);
        if (emotecom.bought == true)
            gainChance = gainChance * 1.1f;
        if (l2d1.bought == true && l2d2.bought == false)
            gainChance = gainChance * 1.1f;
        if (l2d1.bought == false && l2d2.bought == true)
            gainChance = gainChance * 1.2f;
        if (merch_s.bought == true)
            gainChance = gainChance * 1.1f;
        if (merch_l.bought == true)
            gainChance = gainChance * 1.2f;
        if (mocap.bought == true)
            gainChance = gainChance * 1.3f;
        if (layout.bought == true)
            gainChance = gainChance * 1.1f;

        if (Random.Range(0, 100) < gainChance)
        {
            subcount.value = subcount.value + (int)Random.Range(0, gainChance);
        }
    }

    void passiveFollowerGain()
    {
        gainChance = (subcount.value / 100) + (followercount.value / 100);
        if (emotecom.bought == true)
            gainChance = gainChance * 1.1f;
        if (l2d1.bought == true && l2d2.bought == false)
            gainChance = gainChance * 1.3f;
        if (l2d1.bought == false && l2d2.bought == true)
            gainChance = gainChance * 1.5f;
        if (mocap.bought == true)
            gainChance = gainChance * 1.8f;

        if (Random.Range(0, 100) < gainChance)
        {
            followercount.value = followercount.value + (int)Random.Range(0, gainChance);
        }
    }

    void passiveFundsGain()
    {
        gainChance = (subcount.value / 100) + (followercount.value / 100);
        if (emotecom.bought == true)
            gainChance = gainChance * 1.1f;
        if (l2d1.bought == true && l2d2.bought == false)
            gainChance = gainChance * 1.1f;
        if (l2d1.bought == false && l2d2.bought == true)
            gainChance = gainChance * 1.2f;
        if (merch_s.bought == true)
            gainChance = gainChance * 1.5f;
        if (merch_l.bought == true)
            gainChance = gainChance * 1.8f;
        if (mocap.bought == true)
            gainChance = gainChance * 1.3f;
        if (layout.bought == true)
            gainChance = gainChance * 1.2f;

        if (Random.Range(0, 100) < gainChance)
        {
            funds.value = funds.value + (int)Random.Range(0, gainChance);
        }
    }
}
