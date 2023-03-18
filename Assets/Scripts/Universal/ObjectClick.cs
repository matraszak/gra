using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectClick : MonoBehaviour
{
    #region ObjectClick instanse
    public static ObjectClick instanse;

    private void Awake()
    {
        instanse = this;
    }
    #endregion

    public MonoBehaviour Script;

    public delegate void OnPoiterClick();
    public OnPoiterClick onPoiterClickCallback;

    public void CallScript()
    {
        Debug.Log(Script);
        onPoiterClickCallback.Invoke();
    }
}
