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
    public bool ForcedObject = false;


    public GameObject FocusedObject;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&FocusedObject!=null)
        {
            if(!ForcedObject)
            {
                Destroy(FocusedObject);
                FocusedObject = null;
                canClone = true;
            }
            else
            {
                FocusedObject.SetActive(false);
                FocusedObject = null;
                canClone = true;
                ForcedObject = false;
            }
            
        }
    }
}
