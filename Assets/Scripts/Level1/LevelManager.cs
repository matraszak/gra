using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    #region LevelManager instanse
    public static LevelManager instanse;

    private void Awake()
    {
        instanse = this;
    }
    #endregion


    public bool[] SwitchedPower = { true, false, false, false, false, false, false }; //[0] - in front lamp, [1] - outside lamps, [2] - in shop lamps, [3] - cash, 

    public bool Water = true;
}
