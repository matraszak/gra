using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevel : MonoBehaviour
{
    public int NumberOfLevels = 2;

    public GameObject LevelBlock;

    public Animator animator;
    int direction = 1;

    private void Update()
    {
        if (GameManager.instanse.canRotate)
        {


            if (Input.GetKeyDown(KeyCode.E))
            {
                //RotateLevelFunction();
                direction = 1;
                GameManager.instanse.canRotate = false;
                animator.SetTrigger("Play");
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                //RotateLevelFunction();
                direction = -1;
                GameManager.instanse.canRotate = false;
                animator.SetTrigger("Play");
            }
        }
    }

    public void RotateLevelFunction()
    {
        LevelBlock.transform.Rotate(0, (360 / NumberOfLevels) * direction, 0);
    }

    public void End()
    {
        GameManager.instanse.canRotate = true;
    }
}
