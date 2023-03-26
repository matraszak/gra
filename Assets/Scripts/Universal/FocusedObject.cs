using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusedObject : MonoBehaviour
{
    int direction = 1;
    public int NumberOfFaces = 2;
    private void Update()
    {
        if (GameManager.instanse.FocusedObject == this.gameObject)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                RotateLevelFunction();
                direction = 1;
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                RotateLevelFunction();
                direction = -1;
            }
        }
    }

    public void RotateLevelFunction()
    {
        this.gameObject.transform.Rotate(0, (360 / NumberOfFaces) * direction, 0);
    }
}
