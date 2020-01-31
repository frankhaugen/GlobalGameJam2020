using UnityEngine;
using UnityEngine.InputSystem;

public class BasicCharacterMovement : MonoBehaviour
{
    private bool IsDKeyDown;
    private bool IsAKeyDown;
    private bool IsJumping;
    private bool IsInAir;

    [Range(1.0f, 10.0f)]
    public float SpeedMultiplier;
    void Start()
    {

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
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            IsJumping = true;
        }
    }

    void FixedUpdate()
    {
        if (IsDKeyDown && !IsInAir)
        {
            //GetComponent<Rigidbody2D>().AddForce(Vector2.right * 25.0f, ForceMode2D.Force);
            transform.Translate(Vector2.right);
        }
        if (IsAKeyDown && !IsInAir)
        {
            //GetComponent<Rigidbody2D>().AddForce(Vector2.left * 25.0f, ForceMode2D.Force);
            transform.Translate(Vector2.left);
        }
        if (IsJumping && !IsInAir)
        {
            //GetComponent<Rigidbody2D>().AddForce(Vector2.up * 25.0f, ForceMode2D.Impulse);
            transform.Translate(Time.deltaTime * 50f * Vector2.up);
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
