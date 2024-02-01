using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AHKTrigger
{
    public Func<bool> Condtion;
    public virtual bool IsMatchup()
    {
        if (Condtion != null)
        {
            return Condtion();
        }
        return false;
    }

    public AHKTrigger()
    { 
    
    }
}
