using UnityEngine;

public class RotateLevel : MonoBehaviour
{
    public int NumberOfLevels = 2;

    public GameObject LevelBlock;
    public GameObject Camera;

    public float[] pos1 = { 0, 0, 0 };
    public float[] rot1 = { 0, 0, 0 };
    public float[] pos2 = { 0, 0, 0 };
    public float[] rot2 = { 0, 0, 0 };
    public bool position = false;

    public Animator animator;
    int direction = 1;

    private void Update()
    {
        if (GameManager.instanse.canRotate)
        {


            if (Input.GetKeyDown(KeyCode.E))
            {
                //RotateLevelFunction();
                direction = 1;
                GameManager.instanse.canRotate = false;
                animator.SetTrigger("Play");
            }
            else if (Input.GetKeyDown(KeyCode.Q))
            {
                //RotateLevelFunction();
                direction = -1;
                GameManager.instanse.canRotate = false;
                animator.SetTrigger("Play");
            }
        }
    }
    public void RotateRight()
    {
        if (GameManager.instanse.canRotate)
        {
            direction = 1;
            GameManager.instanse.canRotate = false;
            animator.SetTrigger("Play");
            if(position)
            {
                Camera.transform.position = new Vector3(pos1[0], pos1[1], pos1[2]);
                Camera.transform.rotation.SetEulerRotation(rot1[0], rot1[1], rot1[2]);
                position = false;
            }
            else
            {
                Camera.transform.position = new Vector3(pos2[0], pos2[1], pos2[2]);
                Camera.transform.rotation.SetEulerRotation(rot2[0], rot2[1], rot2[2]);
                position = true;
            }
        }
    }

    public void RotateLight()
    {
        if (GameManager.instanse.canRotate)
        {
            direction = -1;
            GameManager.instanse.canRotate = false;
            animator.SetTrigger("Play");
            if (position)
            {
                Camera.transform.position = new Vector3(pos1[0], pos1[1], pos1[2]);
                Camera.transform.rotation.SetEulerRotation(rot1[0], rot1[1], rot1[2]);
                position = false;
            }
            else
            {
                Camera.transform.position = new Vector3(pos2[0], pos2[1], pos2[2]);
                Camera.transform.rotation.SetEulerRotation(rot2[0], rot2[1], rot2[2]);
                position = true;
            }
        }
    }

    public void RotateLevelFunction()
    {
        LevelBlock.transform.Rotate(0, (360 / NumberOfLevels) * direction, 0);
    }

    public void End()
    {
        GameManager.instanse.canRotate = true;
    }
}
