using UnityEngine;

public class RightMover : MonoBehaviour
{
    public static bool canMove = true;

    private Rigidbody2D rb;
    public static float speed = 5;
    private static float jumpForce = 30;
    public static bool CanJump = true;
    public float downForce;

    //отвечают за проверку находится ли персонаж на земле
    private bool IsGrounded;
    public Transform fitPos;
    public float CheckRadius;
    public LayerMask WhatIsGround;

    public static float JumpForce { get => jumpForce; set => jumpForce = value; }

    //присваиваю переменной (полю хз) компонент Rigidbody2D
    private void Start()
    {
        rb = GetComponent <Rigidbody2D>();
    }


    //заставляю персонажа двигаться
    void FixedUpdate()
    {
        if (canMove)
        {
            rb.velocity = new Vector2(1 * speed, rb.velocity.y);
        }
        
    }

    //заставляю персонажа прыгать при нажатии на UpArrow
    private void Update()
    {
        IsGrounded = Physics2D.OverlapCircle(fitPos.position, CheckRadius, WhatIsGround);
        if (IsGrounded == true && Input.GetKeyDown(KeyCode.UpArrow) && CanJump)
        {
            rb.velocity = Vector2.up * JumpForce;
        }
        if (IsGrounded == false && Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = Vector2.down * downForce;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "moveplatform")
        {
            transform.parent = col.transform;
        }
    }
    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "moveplatform")
        {
            transform.parent = null;
        }
    }
}
