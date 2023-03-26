using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWell : ClickOnObject
{
    Animator animator;
    private void Awake()
    {
        if (this.GetComponent<Animator>())
            animator = this.GetComponent<Animator>();
    }

    public override void OnClick()
    {
        if (LevelManagerTutorial.instanse.LevelStage == 0 || LevelManagerTutorial.instanse.LevelStage == 1)
        {
            GameManager.instanse.canClick = false;
            if (LevelManagerTutorial.instanse.Water)
            {
                animator.SetTrigger("Play");

            }
            if (!LevelManagerTutorial.instanse.Water)
            {
                animator.SetTrigger("Play");
                LevelManagerTutorial.instanse.LevelStage = 2;
            }
        }
    }
    public void AnimationEvent()
    {
        GameManager.instanse.canClick = true;
    }
}
