using UnityEngine;

class VelocityRaycast : MonoBehaviour
{
    void FixedUpdate()
    {
        var ray = new Ray(transform.position, transform.right);
        if (Physics.Raycast(ray, out var hitInfo))
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red, 0.5f);
        }
    }
}
