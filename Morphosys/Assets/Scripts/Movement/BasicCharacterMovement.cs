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

    [Range(10.0f, 100.0f)]
    public float AttackForceMultiplier = 10.0f;

    [Range(10.0f, 100.0f)]
    public float SpeedForceMultiplier = 10.0f;

    [Range(10.0f, 100.0f)]
    public float JumpForceMultiplier = 10.0f;

    [Range(10.0f, 100.0f)]
    public float MaxSpeed = 10.0f;

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
        if (IsDKeyDown && !IsInAir && Character.velocity.x < MaxSpeed)
        {
            Character.AddForce(Vector2.right * SpeedForceMultiplier, ForceMode2D.Force);
        }
        if (IsAKeyDown && !IsInAir && Character.velocity.x > -MaxSpeed)
        {
            Character.AddForce(Vector2.left * SpeedForceMultiplier, ForceMode2D.Force);
        }
        if (IsAttacking)
        {
            Character.AddForce(Vector2.down * AttackForceMultiplier, ForceMode2D.Impulse);
            IsAttacking = false;
        }
        if (IsJumping && !IsInAir)
        {
            Character.AddForce(Vector2.up * JumpForceMultiplier, ForceMode2D.Impulse);
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
