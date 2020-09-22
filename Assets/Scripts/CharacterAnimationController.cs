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

        bool isWalking = (horizontal != 0f || vertical != 0f);

        animator.SetBool("isWalking", isWalking);

        Debug.Log(string.Format("Horizontal: {0} Vertical: {1}", horizontal, vertical));
    }
}
