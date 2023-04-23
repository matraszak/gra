using UnityEngine;

public class ResetBtn : ClickOnObject
{
    public Animator animator;

    private void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }
    public override void OnClick()
    {
        LevelManagerTutorial.instanse.SafeboxCode.Clear();
        animator.SetTrigger("Play");
    }
}
