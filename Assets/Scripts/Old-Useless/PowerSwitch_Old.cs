using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSwitch_Old : MonoBehaviour
{
    public int number;
    public Animator animator;
    bool reverse = false;

    private void Start()
    {
        ObjectClick.instanse.onPoiterClickCallback += Switch;
    }

    void Switch()
    {
        Debug.Log("Switch " + reverse + number);
        LevelManager.instanse.SwitchedPower[number] = !reverse;
        if(reverse)
        {
            reverse = false;
            animator.SetTrigger("PlayReverse");
        }
        else if(!reverse)
        {
            reverse = true;
            animator.SetTrigger("Play");
        }
    }
}
