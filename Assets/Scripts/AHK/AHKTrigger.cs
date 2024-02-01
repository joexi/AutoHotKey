using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKTriggerColor:AHKTrigger
{
    public AHKColor MatchupColor = new AHKColor(0, 0, 0);
    public AHKPos MatchupPos = new AHKPos();
    public override bool IsMatchup()
    {
        var color = AHKColorPicker.GetColor(MatchupPos);
        return MatchupColor.IsEquals(color);
    }

    public void SetMatchupColor(int r, int g, int b)
    {
        MatchupColor.R = r;
        MatchupColor.G = g;
        MatchupColor.B = b;
    }
    public void SetMatchupPos(int x, int y)
    {
        MatchupPos.x = x;
        MatchupPos.y = y;
    }

    public AHKTriggerColor()
    { 
    
    }

}
