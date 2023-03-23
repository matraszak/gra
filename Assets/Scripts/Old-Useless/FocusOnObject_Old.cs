using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusOnObject_Old : MonoBehaviour
{

    public float[] position = { 0f, 0f, -7.5f };

    GameObject prefab;
    public delegate void OnPoiterClicked();
    public OnPoiterClicked onPoiterClickedCallback;

    private void Start()
    {
        //ObjectClick.instanse.onPoiterClickCallback += ShowObject;
        onPoiterClickedCallback += ShowObject;
    }

    void ShowObject()
    {
        Debug.Log(this.gameObject.name + "FocusOnObject");
        prefab = this.gameObject;
        if (GameManager.instanse.canClone)
        {
            GameManager.instanse.FocusedObject = Instantiate(prefab, new Vector3(position[0], position[1], position[2]), prefab.transform.rotation);
            GameManager.instanse.FocusedObject.layer = 2;
            GameManager.instanse.canClone = false;
            
        }
    }
}
