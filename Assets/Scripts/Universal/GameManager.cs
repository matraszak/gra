using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region GameManager instanse
    public static GameManager instanse;

    private void Awake()
    {
        instanse = this;
    }
    #endregion

    public bool canClone = true;


    public GameObject FocusedObject;



    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&FocusedObject!=null)
        {
            Destroy(FocusedObject);
            FocusedObject = null;
            canClone = true;
        }
    }
}
