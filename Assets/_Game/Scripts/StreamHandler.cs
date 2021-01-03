using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreamHandler : MonoBehaviour
{
    public IntValue subcount, followercount, funds;
    public BoolValue l2d1, l2d2, mocap, emotes, layout, merch_s, merch_l;

    public void onClick()
    {
        int i = Random.Range(1, 100);

        streamGain(i);
    }

    void streamGain(int i)
    {
        float gain = (subcount.value / 100) + (followercount.value / 100);
        if (gain < 1)
            gain = 1;
        if (emotes.bought == true)
            gain = gain * 1.2f;
        if (l2d1.bought == true && l2d2.bought == false)
            gain = gain * 1.1f;
        if (l2d1.bought == false && l2d2.bought == true)
            gain = gain * 1.4f;
        if (mocap.bought == true)
            gain = gain * 1.6f;
        if (merch_s.bought == true)
            gain = gain * 1.1f;
        if (merch_l.bought == true)
            gain = gain * 1.3f;
        if (layout.bought == true)
            gain = gain * 1.1f;

        if (i > 50 && i < 85)
        {
            subcount.value = subcount.value + (int)Random.Range(1, gain/2);
            followercount.value = followercount.value + (int)Random.Range(1, gain);
            funds.value = funds.value + (int)Random.Range(1, gain/2);
        }
        else if (i >= 85 && i <= 98)
        {
            subcount.value = subcount.value + (int)Random.Range(1, gain*1.5f);
            followercount.value = followercount.value + (int)Random.Range(gain, gain * 2);
            funds.value = funds.value + (int)Random.Range(gain / 5, gain);
        }
        else if (i > 98)
        {
            subcount.value = subcount.value + (int)Random.Range(gain, gain * 3) + 200;
            followercount.value = followercount.value + (int)Random.Range(gain * 2, gain * 4) + 500;
            funds.value = funds.value + (int)Random.Range(gain, gain * 2);
        }
        else
        {
            subcount.value = subcount.value + (int)Random.Range(1, gain / 3);
            funds.value = funds.value + (int)Random.Range(0, gain / 3);
        }
    }
}
