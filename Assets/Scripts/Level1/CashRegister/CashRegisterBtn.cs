using UnityEngine;

public class CashRegisterBtn : ClickOnObject
{
    public int number;
    public Animator animator;
    public override void OnClick()
    {
        Click();

    }

    void Click()
    {
        if (LevelManagerTutorial.instanse.canEnterCode)
        {
            LevelManagerTutorial.instanse.Code.Add(number);
            animator.Play(0);
            if (LevelManagerTutorial.instanse.Code.Count == 6)
            {
                LevelManagerTutorial.instanse.CheckCode();
            }
        }
    }

}
