using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAnimController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayFirstAnimation()
    {
        animator.Play("Scene");
    }

    public void PlaySecondAnimation()
    {
        animator.Play("Scene 1");
    }
}
