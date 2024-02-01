using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKColor
{
    public int R;
    public int G;
    public int B;

    public bool IsEquals(AHKColor c)
    {
        return R == c.R && B == c.B && G == c.G;
    }
    public AHKColor(Color c)
    {
        R = (int)(c.r * 255);
        G = (int)(c.g * 255);
        B = (int)(c.b * 255);
    }
    public AHKColor(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public void Log()
    {
        Debug.Log("r:" + R + " g:" + G + " b:" + B);
    }
     
}
