using UnityEngine;

public class FocusOnObject : ClickOnObject
{
    public float[] position = { 1.5f, 0f, -7.5f };
    public float[] rotate = { 0.0f, 0.0f, 0.0f };

    GameObject prefab;
    public GameObject ForceObject = null;

    public override void OnClick()
    {
        ShowObject();
    }

    void ShowObject()
    {
        Debug.Log(this.gameObject.name + "FocusOnObject");
        if (ForceObject == null)
        {
            prefab = this.gameObject;
            if (GameManager.instanse.canClone)
            {
                GameManager.instanse.FocusedObject = Instantiate(prefab, new Vector3(position[0], position[1], position[2]), prefab.transform.rotation);
                GameManager.instanse.FocusedObject.transform.rotation = Quaternion.Euler(rotate[0], rotate[1], rotate[2]);
                GameManager.instanse.FocusedObject.layer = 2;
                GameManager.instanse.canClone = false;

            }
        }
        else
        {
            if (GameManager.instanse.canClone)
            {
                ForceObject.SetActive(true);
                GameManager.instanse.ForcedObject = true;
                GameManager.instanse.canClone = false;
                GameManager.instanse.FocusedObject = ForceObject.gameObject;
            }
        }
    }
}
