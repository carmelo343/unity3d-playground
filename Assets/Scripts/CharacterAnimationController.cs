using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        bool isRunning = (horizontal != 0f || vertical != 0f);

        animator.SetBool("isRunning", isRunning);


        Debug.Log(string.Format("Horizontal: {0} Vertical: {1}", horizontal, vertical));
    }
}
