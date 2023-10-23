using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
enum FlipDirection
{
    X,
    Y,
}

public class PlayerSC : MonoBehaviour
{
    //r?cuperer l'animator
    Animator animator;
    GameObject InverterScript;

    // d?placements
    public float horizontal;
    private float speed = 4f;
    private float jumpingPower = 7f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    void Update()
    {

        animator.SetBool("isWalking", horizontal != 0);
        animator.SetBool("animIsGrounded", IsGrounded());

        CheckOrientationX();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        bool grounded = Physics2D.OverlapCircle(groundCheck.position, 0.137f, groundLayer);
        return grounded;
    }

    //Animation
    private void CheckOrientationX()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Flip(FlipDirection.X);
        }
    }

    private void Flip(FlipDirection direction)
    {
        Vector3 localScale = transform.localScale;
        switch (direction)
        {
            case FlipDirection.X:
                localScale.x *= -1f;
                break;

            case FlipDirection.Y:
                localScale.y *= -1f;
                break;
        }
        transform.localScale = localScale;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            // Restart le niveau
            case "Death":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;
            // Inverse la gravité
            case "Inverter":
                if (collision.gameObject.GetComponent<InverterCDSC>().isOnCooldown == false)
                {
                    InvertGravity();
                    StartCoroutine(collision.gameObject.GetComponent<InverterCDSC>().CoolDownInverter());
                    collision.gameObject.GetComponent<InverterCDSC>().isOnCooldown = true;
                }
                break;
            case "Gravity button":
                {
                    LessenGravity(0.1f);
                }
                break;

        }
    }
    // Inverse le sprite, la gravité et le saut
    public void InvertGravity()
    {
        rb.gravityScale *= -1;
        jumpingPower *= -1;
        Flip(FlipDirection.Y);
    }
    public void LessenGravity( float multiplier)
    {
        rb.gravityScale *= multiplier;
    }


    public void OnRestartGame(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            RestartGame();
        }
    }
    private void RestartGame()
    {
        SceneManager.LoadScene("niveau1");
        GameObject.Find("Chrono").GetComponent<TimerSC>().timerCount = 0;
    }
}
