using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AHKGrabber
{
    public AHKPos Pos = new AHKPos();
    public AHKColor Result;

    public virtual void Grab()
    {
        this.Result = AHKColorPicker.GetColor(Pos);
    }
}
