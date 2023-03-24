using UnityEngine;

public class PowerSwitch : ClickOnObject
{
    public int number;
    public Animator animator;
    public bool reverse_switched = false;


    public override void OnClick()
    {
        Switch();
    }

    void Switch()
    {
        Debug.Log("Switch " + reverse_switched + number);
        LevelManagerTutorial.instanse.SwitchedPower[number] = !reverse_switched;
        LevelManagerTutorial.instanse.Switch(number);
        if (reverse_switched)
        {
            reverse_switched = false;
            animator.SetTrigger("PlayReverse");
        }
        else if (!reverse_switched)
        {
            reverse_switched = true;
            animator.SetTrigger("Play");
        }
    }

}
