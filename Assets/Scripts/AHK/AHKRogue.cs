using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKRogue : AHKRotation
{
    public override void Setup()
    {
        base.Setup();
        this.AddSkill(new AHKSkill("切割", KeyCode.Alpha1, new AHKColor(255, 0, 0), AHKPos.Center));
        this.AddSkill(new AHKSkill("影袭", KeyCode.Alpha2, new AHKColor(254, 0, 0), AHKPos.Center));
        var skill = new AHKSkill("斩击", KeyCode.Alpha3);
        skill.Trigger.Condtion = () =>
        {
            return AHKEnv.IsStealth ? AHKEnv.CombatPoint >= 5 : AHKEnv.CombatPoint >= 6;
        };
        this.AddSkill(skill);
        this.AddGrabber(new AHKGrabberCombatPoint());
        this.AddGrabber(new AHKGrabberHPMP());
    }
}
