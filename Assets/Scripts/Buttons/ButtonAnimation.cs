using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
	[SerializeField] Animator animator;
    public GameObject menuFrom;
    public GameObject menuTo;
    public void pressed()
	{
        animator.SetBool("select", true);
        animator.SetBool("pressed", true);
    }
    private void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("pressed"))
        {
            menuFrom.SetActive(false);
            menuTo.SetActive(true);
        }
    }
}
