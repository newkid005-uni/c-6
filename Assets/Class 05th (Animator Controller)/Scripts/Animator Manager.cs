using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;

    public void Die()
    {
        animator.SetTrigger("Die");
    }

    public void Attack()
    {
        animator.SetBool("Attack", true);
        animator.SetBool("Walk", false);
    }

    public void Walk()
    {
        animator.SetBool("Walk",true);
        animator.SetBool("Attack", false);
    }

    public void Idle()
    {
        animator.SetBool("Walk", false);
        animator.SetBool("Attack", false);
    }
}
