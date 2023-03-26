using UnityEngine;

public class PickupThingsFromShelf : ClickOnObject
{
    public bool[] things = { false, false }; // 0 - Key, 1 - Money
    public override void OnClick()
    {
        if(things[0])
        {
            LevelManagerTutorial.instanse.canOpenDoor = true;
            Destroy(this.gameObject);
        }
        else if(things[1])
        {
            Destroy(this.gameObject);
        }
    }
}
