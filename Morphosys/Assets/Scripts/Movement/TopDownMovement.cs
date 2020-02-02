using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownMovement : MonoBehaviour
{
    public bool IsDKeyDown;
    public bool IsAKeyDown;
    public bool IsWKeyDown;
    public bool IsSKeyDown;

    [Range(1.0f, 10.0f)] public float TurnMultiplier = 1.0f;

    private Animator animation;

    private void Start()
    {
        animation = GetComponent<Animator>();
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
        if (Keyboard.current.wKey.wasReleasedThisFrame)
        {
            IsWKeyDown = false;
        }
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            IsWKeyDown = true;
        }
        if (Keyboard.current.sKey.wasReleasedThisFrame)
        {
            IsSKeyDown = false;
        }
        if (Keyboard.current.sKey.wasPressedThisFrame)
        {
            IsSKeyDown = true;
        }
    }

    void FixedUpdate()
    {
        if (IsAKeyDown)
        {
            transform.Rotate(Vector3.forward * TurnMultiplier);
        }
        if (IsDKeyDown)
        {
            transform.Rotate(Vector3.back * TurnMultiplier);
        }
        if (IsWKeyDown)
        {
            transform.Translate(Vector3.right);
        }
        if (IsSKeyDown)
        {
            transform.Translate(Vector3.left);
        }
    }
}
