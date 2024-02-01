using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKGrabberCombatPoint : AHKGrabber
{
    public override void Grab()
    {
        base.Grab();
        AHKEnv.CombatPoint = this.Result.R;
    }
}
