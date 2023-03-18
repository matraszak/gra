using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevel : MonoBehaviour
{
    public int NumberOfLevels = 2;

    public GameObject LevelBlock;

    private void Start()
    {
        LevelBlock = this.gameObject;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            RotateLevelFunction(1);
        else if (Input.GetKeyDown(KeyCode.Q))
            RotateLevelFunction(-1);
    }

    void RotateLevelFunction(int direction)
    {
        Debug.Log("Works");
        LevelBlock.transform.Rotate(0, (360 / NumberOfLevels)* direction, 0);
    }
}
