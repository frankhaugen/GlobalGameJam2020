using UnityEngine;
using UnityEngine.InputSystem;

public class BasicCharacterMovement : MonoBehaviour
{
    [ReadOnly] public bool IsDKeyDown;
    [ReadOnly] public bool IsAKeyDown;
    [ReadOnly] public bool IsAttacking;
    [ReadOnly] public bool IsJumping;
    [ReadOnly] public bool IsInAir;

    private Rigidbody2D Character;

    [Range(1.0f, 10.0f)]
    public float AttackForceMultiplier;

    [Range(1.0f, 10.0f)]
    public float SpeedForceMultiplier;

    [Range(1.0f, 10.0f)]
    public float JumpForceMultiplier;

    private void Start()
    {
        Character = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Keyboard.current.dKey.wasReleasedThisFrame)
        {
            IsDKeyDown = false;
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            IsDKeyDown = true;
        }
        if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            IsAKeyDown = false;
        }
        if (Keyboard.current.aKey.wasPressedThisFrame)
        {
            IsAKeyDown = true;
        }
        if (Mouse.current.leftButton.isPressed && IsInAir && Character.velocity.y < 0)
        {
            IsAttacking = true;
        }
        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            IsAttacking = false;
        }
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !IsInAir)
        {
            IsJumping = true;
        }
    }

    void FixedUpdate()
    {
        if (IsDKeyDown && !IsInAir)
        {
            Character.AddForce(Vector2.right * SpeedForceMultiplier, ForceMode2D.Force);
            //transform.Translate(Vector2.right * Time.deltaTime * SpeedMultiplier);
        }
        if (IsAKeyDown && !IsInAir)
        {
            Character.AddForce(Vector2.left * SpeedForceMultiplier, ForceMode2D.Force);
            //transform.Translate(Vector2.left * Time.deltaTime * SpeedMultiplier);
        }
        if (IsAttacking)
        {
            Character.AddForce(Vector2.down * AttackForceMultiplier, ForceMode2D.Impulse);
            IsAttacking = false;
            //transform.Translate(Vector2.left * Time.deltaTime * SpeedMultiplier);
        }
        if (IsJumping && !IsInAir)
        {
            Character.AddForce(Vector2.up * JumpForceMultiplier, ForceMode2D.Impulse);
            //transform.Translate(Time.deltaTime * 50f * Vector2.up);
            //GetComponent<Rigidbody2D>().MovePosition(Vector2.up * Time.deltaTime);
            IsJumping = false;
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        IsInAir = false;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        IsInAir = false;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        IsInAir = true;
    }
}
