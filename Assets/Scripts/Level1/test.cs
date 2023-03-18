using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private void Start()
    {
        ObjectClick.instanse.onPoiterClickCallback += ShowObject;
        
    }

    void ShowObject()
    {
        Debug.Log("test");
    }
}
