using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public AnimatorStateInfo animatorStateInfo;

    public void Die()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (!animatorStateInfo.IsName("Die") && !animator.IsInTransition(0))
        {
            animator.SetTrigger("Die");
        }
        else
        {
            return;
        }
    }

    public void Attack()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Walk"))
        {
            animator.SetBool("Walk", false);
        }
        else if (animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Idle", false);
        }

        animator.SetBool("Attack", true);
    }

    public void Walk()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if(animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Attack", false);
        }
        else if(animatorStateInfo.IsName("Idle"))
        {
            animator.SetBool("Idle", false);
        }

        animator.SetBool("Walk",true);
    }

    public void Idle()
    {
        animatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);

        if (animatorStateInfo.IsName("Attack"))
        {
            animator.SetBool("Attack", false);
        }
        else if (animatorStateInfo.IsName("Walk"))
        {
            animator.SetBool("Walk", false);
        }

        animator.SetBool("Idle", true);
    }
}
