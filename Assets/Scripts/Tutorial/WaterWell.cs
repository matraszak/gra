using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterWell : ClickOnObject
{
    Animator animator;
    private void Awake()
    {
        if(this.GetComponent<Animator>())
            animator = this.GetComponent<Animator>();
    }
    public override void OnClick()
    {
        
    }
}
