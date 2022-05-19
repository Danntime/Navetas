using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSC : MonoBehaviour
{
    //récuperer l'animator
    Animator animator;
    // déplacements
    private float horizontal;
    private float speed = 4f;
    private float jumpingPower = 7f;
    private bool isFacingRight = true;
    private bool m_isWalking;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
      void Start()
    {
        animator = GetComponent<Animator>();
        m_isWalking = false;
    }

    void Update()
    {
        if (horizontal == 0)
        {
            m_isWalking = false;
        }
        else
        {
            m_isWalking = true;
        }

        if (m_isWalking == true)
            {
            animator.SetBool("isWalking", true);
            }
        if (m_isWalking == false)
        {
            animator.SetBool("isWalking", false);
        }
        if (IsGrounded() == true)
        {
            animator.SetBool("animIsGrounded", true);
        }
        if (IsGrounded() == false)
        {
            animator.SetBool("animIsGrounded", false);
        }

        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    //Animation
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<float>();
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower); ;
        }
    }
}