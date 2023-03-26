using UnityEngine;

public class PointerClick : MonoBehaviour
{
    Camera Camera;


    private void Start()
    {
        Camera = this.gameObject.GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && GameManager.instanse.canClick)
        {
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject.name);
                if (hit.transform.gameObject.GetComponent<ClickOnObject>())
                    hit.transform.gameObject.GetComponent<ClickOnObject>().OnClick();
            }
        }
    }

}

