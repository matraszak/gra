using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeboxClick : ClickOnObject
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            LevelManagerTutorial.instanse.rotate(-1);
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            LevelManagerTutorial.instanse.rotate(1);
        }
    }
}
