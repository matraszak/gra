using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerTutorial : MonoBehaviour
{

    #region LevelManager instanse
    public static LevelManagerTutorial instanse;

    private void Awake()
    {
        instanse = this;
    }
    #endregion
    #region power
    [Header("Power")]
    public bool[] SwitchedPower = { true, false, false, false, false, false, false }; //[0] - in front lamp, [1] - outside lamps, [2] - in shop lamps, [3] - cash, 
    public List<GameObject> Lamp0Lights = new List<GameObject>();
    public void Switch(int number)
    {
        switch (number)
        {
            case 0:
                for (int i = 0; i < Lamp0Lights.Count; i++)
                {
                    Lamp0Lights[i].SetActive(!Lamp0Lights[i].activeSelf);
                }
                break;
        }
    }
    #endregion


    public bool Water = true;

    #region Code
    [Header("Code")]
    public List<int> Code = new List<int>();
    List<int> CorrectCode = new List<int> { 4, 7, 2, 6, 1, 9 };
    public bool canEnterCode = true;

    public bool canOpenDoor = false;

    public void CheckCode()
    {
        bool isExact = true;
        for(int i = 0; i<6; i++)
        {
            if(Code[i] != CorrectCode[i])
            {
                isExact = false;
                break;
            }
        }
        if (isExact)
        {
            canEnterCode = false;
        }
        else
        {
            Code.Clear();
        }
    }
    #endregion

}
