using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public CharController controller;

    public float HorizontalMove;
    public float RunSpeed = 40f;

    public bool jump = false;
    public bool crouch = false;

    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * RunSpeed;

        animator.SetFloat("Speed", Mathf.Abs(HorizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    private void FixedUpdate()
    {
        controller.Move(HorizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
