using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKGrabberHPMP : AHKGrabber
{
    public override void Grab()
    {
        base.Grab();
        AHKEnv.HP = this.Result.G;
        AHKEnv.MP = this.Result.B;
    }
}

