using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKSkill
{
    public string SkillName;
    public int SkillID;
    public KeyCode SkillHotkey;
    public AHKTrigger Trigger = null;
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
        var t = new AHKTriggerColor();
        t.MatchupColor = color;
        t.MatchupPos = pos;
        this.Trigger = t;
    }

    public AHKSkill(string skillName, KeyCode hotkey)
    {
        this.SkillName = skillName;
        this.SkillHotkey = hotkey;
        this.Trigger = new AHKTrigger();
    }
}
