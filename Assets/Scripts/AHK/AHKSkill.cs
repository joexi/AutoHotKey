using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKSkill
{
    public string SkillName;
    public int SkillID;
    public KeyCode SkillHotkey;
    public AHKColor MatchupColor = new AHKColor(0, 0, 0);
    public AHKPos MatchupPos = new AHKPos();
    public bool IsMatchup(AHKColor color)
    {
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

    public void Excute()
    {
        Debug.Log("excute skill " + this.SkillName);
        AutoJob.ClickKey(SkillHotkey);
    }

    public AHKSkill(string skillName, KeyCode hotkey, AHKColor color, AHKPos pos)
    {
        this.SkillName = skillName;
        this.SkillHotkey = hotkey;
        this.MatchupColor = color;
        this.MatchupPos = pos;
    }
}
