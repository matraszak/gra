using UnityEngine;

public class Door : ClickOnObject
{
    public override void OnClick()
    {
        if(LevelManagerTutorial.instanse.canOpenDoor)
        {
            Debug.Log("Opening the door");
            this.gameObject.layer = 2;
        }
        else
        {
            Debug.Log("You have to have a key.");
        }
    }
}
