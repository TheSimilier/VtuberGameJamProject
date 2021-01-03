using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostHandler : MonoBehaviour
{
    public IntValue subcount, followercount;
    public BoolValue l2d1, l2d2, mocap;

    public void onClick()
    {
        int i = Random.Range(1, 100);

        postGain(i);
    }

    void postGain(int i)
    {
        float gain = followercount.value / 100;
        if (gain < 1)
            gain = 1;
        if (l2d1.bought == true && l2d2.bought == false)
            gain = gain * 1.3f;
        if (l2d1.bought == false && l2d2.bought == true)
            gain = gain * 1.5f;
        if (mocap.bought == true)
            gain = gain * 1.8f;

        if(i > 50 && i < 85)
        {
            subcount.value = subcount.value + (int)Random.Range(0, gain/3);
            followercount.value = followercount.value + (int)Random.Range(1, gain);
        }
        else if(i >= 85 && i <= 98)
        {
            subcount.value = subcount.value + (int)Random.Range(1, gain);
            followercount.value = followercount.value + (int)Random.Range(gain, gain*2);
        }
        else if(i > 98)
        {
            subcount.value = subcount.value + (int)Random.Range(gain, gain*2) + 200;
            followercount.value = followercount.value + (int)Random.Range(gain*2, gain * 4) + 500;
        }
        else
        {
            followercount.value = followercount.value + (int)Random.Range(1, gain/3);
        }
    }
}
