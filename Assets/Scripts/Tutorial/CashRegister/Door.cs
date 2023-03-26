using UnityEngine;

public class Door : ClickOnObject
{
    Animator animator;

    private void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }
    public override void OnClick()
    {
        if(LevelManagerTutorial.instanse.canOpenDoor)
        {
            animator.SetTrigger("Play");
            Debug.Log("Opening the door");
            this.gameObject.layer = 2;
            LevelManagerTutorial.instanse.LevelStage = 4;
        }
        else
        {
            Debug.Log("You have to have a key.");
        }
    }
}
