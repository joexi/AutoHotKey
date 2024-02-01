using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKSkill
{
    public string SkillName;
    public int SkillID;
    public KeyCode SkillHotkey;
    public AHKTrigger Trigger = new AHKTrigger();
    public AHKColor MatchupColor = new AHKColor(0, 0, 0);
    public AHKPos MatchupPos = new AHKPos();
    public bool IsMatchup()
    {
        return Trigger.IsMatchup();
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
        this.Trigger.MatchupColor = color;
        this.Trigger.MatchupPos = pos;
    }
}
