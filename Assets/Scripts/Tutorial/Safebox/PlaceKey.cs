using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceKey : ClickOnObject
{
    public GameObject key;

    public override void OnClick()
    {
        key.SetActive(true);

    }
}
