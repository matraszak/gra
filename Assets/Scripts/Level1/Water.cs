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
        }
        else if (!LevelManagerTutorial.instanse.Water)
        {
            animator.SetTrigger("PlayReverse");
            LevelManagerTutorial.instanse.Water = true;
        }
    }
}
