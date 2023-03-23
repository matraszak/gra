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

    public Component component;

    public delegate void OnPoiterClick();
    public OnPoiterClick onPoiterClickCallback;

    public void CallScript()
    {
        Debug.Log("ObjectClick "+this.gameObject.name);
        Debug.Log(Script.name + "monobehaviour");
        Debug.Log(component.name+ " component");
        onPoiterClickCallback.Invoke();
        //component.onPointerClickCallback.Invoke();
    }
}
