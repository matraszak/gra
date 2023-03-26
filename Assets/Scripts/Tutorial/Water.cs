using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : ClickOnObject
{
    public Animator animator;

    public override void OnClick()
    {
        if (LevelManagerTutorial.instanse.Water)
        {
            animator.SetTrigger("Play");
            LevelManagerTutorial.instanse.Water = false;
            if (LevelManagerTutorial.instanse.LevelStage == 0)
            {
                LevelManagerTutorial.instanse.LevelStage = 1;
            }
        }
        else if (!LevelManagerTutorial.instanse.Water)
        {
            animator.SetTrigger("PlayReverse");
            LevelManagerTutorial.instanse.Water = true;
            if (LevelManagerTutorial.instanse.LevelStage == 1)
            {
                LevelManagerTutorial.instanse.LevelStage = 0;
            }
        }
    }
}
