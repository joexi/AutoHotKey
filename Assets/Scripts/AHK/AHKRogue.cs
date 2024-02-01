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
        this.AddSkill(new AHKSkill("斩击", KeyCode.Alpha3, new AHKColor(253, 0, 0), AHKPos.Center));
        this.AddGrabber(new AHKGrabberCombatPoint());
        this.AddGrabber(new AHKGrabberHPMP());
    }
}
