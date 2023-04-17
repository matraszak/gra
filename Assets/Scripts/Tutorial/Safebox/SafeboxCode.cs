using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeboxCode : MonoBehaviour
{
    #region safeboxcode instanse
    public SafeboxCode instanse;
    private void Awake()
    {
        instanse = this;
    }
    #endregion

    public List<int> CorrectCode = new List<int> { 8, 25, 4 };
    public List<int> Code = new List<int>();

    public bool CheckBoxCode()
    {
        bool good = false;
        foreach(int number in Code)
        {
            foreach(int correctnumber in CorrectCode)
            {
                if (correctnumber == number)
                {
                    good = true;
                }
                else
                {
                    good = false;
                    break;
                }
            }
        }
        if (good)
            return true;
        else
            return false;
    }

}
