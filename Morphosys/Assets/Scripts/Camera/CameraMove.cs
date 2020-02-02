using UnityEngine;

[ExecuteAlways]
public class CameraMove : MonoBehaviour
{
    public GameObject Target;

    [Range(1.0f, 100.0f)] public float OffsetX = 1f;

    [Range(1.0f, 100.0f)] public float OffsetY = 1f;

    [Range(1.0f, 100.0f)] public float OffsetZ = 1f;

    [Range(0.1f, 1.0f)] public float Smoothing = 0.1f;

    Vector3 Velocity;
    
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, Target.transform.TransformPoint(new Vector3(OffsetX, OffsetY, -1.0f)) + Vector3.back * OffsetZ, ref Velocity, Smoothing);
    }
}
