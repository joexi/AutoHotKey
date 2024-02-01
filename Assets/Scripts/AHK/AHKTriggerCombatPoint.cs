using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKTriggerCombatPoint : AHKTrigger
{
    public int Condition;
    public override bool IsMatchup()
    {
        return AHKEnv.CombatPoint >= Condition;
    }

    public AHKTriggerCombatPoint()
    { 
        
    }
}
