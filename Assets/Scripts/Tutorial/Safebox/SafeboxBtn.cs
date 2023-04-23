using UnityEngine;

public class SafeboxBtn : ClickOnObject
{
    public int number;
    public Animator animator;

    private void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }
    public override void OnClick()
    {
        Click();
        animator.SetTrigger("Play");
    }

    void Click()
    {
        LevelManagerTutorial.instanse.red.SetActive(false);
        if (LevelManagerTutorial.instanse.canEnterSafeboxCode)
        {
            LevelManagerTutorial.instanse.SafeboxCode.Add(number);
            if (LevelManagerTutorial.instanse.SafeboxCode.Count == 4)
            {
                LevelManagerTutorial.instanse.CheckSafeboxCode();
            }
        }
    }

}
