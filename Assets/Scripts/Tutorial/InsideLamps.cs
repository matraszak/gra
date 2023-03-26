using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideLamps : MonoBehaviour
{
    #region Inside Lamps
    public static InsideLamps instanse;

    private void Awake()
    {
        instanse = this;
    }
    #endregion

    public List<GameObject> ShopLamps = new List<GameObject>();
    public List<GameObject> BackLamps = new List<GameObject>();
    public List<GameObject> Neons = new List<GameObject>();

    public GameObject ShopSwitch;
    public GameObject BackSwitch;

    public void CheckShopLamps()
    {
        if (LevelManagerTutorial.instanse.SwitchedPower[2] && ShopSwitch.GetComponent<LampSwitch>().Switched)
        {
            for (int i = 0; i < ShopLamps.Count; i++)
            {
                ShopLamps[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < ShopLamps.Count; i++)
            {
                ShopLamps[i].SetActive(false);
            }
        }
    }

    public void CheckBackLamps()
    {
        if (LevelManagerTutorial.instanse.SwitchedPower[2] && BackSwitch.GetComponent<LampSwitch>().Switched)
        {
            for (int i = 0; i < BackLamps.Count; i++)
            {
                BackLamps[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < BackLamps.Count; i++)
            {
                BackLamps[i].SetActive(false);
            }
        }
    }

    public void CheckNeons()
    {
        if (LevelManagerTutorial.instanse.SwitchedPower[1])
        {
            for (int i = 0; i < Neons.Count; i++)
            {
                Neons[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < Neons.Count; i++)
            {
                Neons[i].SetActive(false);
            }
        }
    }
}
