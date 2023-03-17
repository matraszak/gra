using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevel : MonoBehaviour
{
    public int NumberOfLevels = 2;

    public GameObject LevelBlock;

    private void Start()
    {
        ObjectClick.instanse.onPoiterClickCallback += RotateLevelFunction;
        LevelBlock = this.gameObject;
    }

    private void Update()
    {
        
    }

    void RotateLevelFunction()
    {
        Debug.Log("Works");
        LevelBlock.transform.Rotate(0, 360 / NumberOfLevels, 0);
    }
}
