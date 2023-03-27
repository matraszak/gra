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

    public bool Water = true;
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
            case 1:
                InsideLamps.instanse.CheckNeons();
                break;
            case 2:
                InsideLamps.instanse.CheckBackLamps();
                InsideLamps.instanse.CheckShopLamps();
                break;
            case 3:
                canEnterCode = !canEnterCode;
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }
    }
    #endregion


    

    #region Code
    [Header("Code")]
    public List<int> Code = new List<int>();
    List<int> CorrectCode = new List<int> { 1, 4, 8 };
    public bool canEnterCode = false;
    public Animator UnderCashShelf;

    public bool canOpenDoor = false;

    public void CheckCode()
    {
        bool isExact = true;
        for (int i = 0; i < CorrectCode.Count; i++)
        {
            if (Code[i] != CorrectCode[i])
            {
                isExact = false;
                break;
            }
        }
        if (isExact)
        {
            canEnterCode = false;
            UnderCashShelf.SetTrigger("Play");
        }
        else
        {
            Code.Clear();
        }
    }
    #endregion

    #region Playing Level
    public int LevelStage = 0; //0 - poczatek, 1 - zakrecenie wody, 2 - wejscie do sklepu, 3 - wlamanie sie do kasy, 4 - wejscie na tyl, 5 - otwarcie sejfu
    public GameObject FrontWalls;
    #endregion
}
