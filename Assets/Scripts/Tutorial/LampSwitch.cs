using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampSwitch : ClickOnObject
{
    public bool Switched = false;

    public override void OnClick()
    {
        Switched = !Switched;
        InsideLamps.instanse.CheckBackLamps();
        InsideLamps.instanse.CheckShopLamps();
    }
}
