using UnityEngine;

//[ExecuteAlways]
public class CameraMove : MonoBehaviour
{
    public GameObject Target;

    //[SerializeField] public readonly Vector3 _offset;

    [Range(1.0f, 10.0f)] public float OffsetX = 1f;

    [Range(1.0f, 10.0f)] public float OffsetY = 1f;

    [Range(1.0f, 10.0f)] public float OffsetZ = 1f;

    [Range(0.1f, 1.0f)] public float Smoothing;

    [ReadOnly] Vector3 Velocity;

    // Start is called before the first frame update
    void Start()
    {
        //var _offset = transform.position - Target.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(OffsetX, OffsetY, -OffsetZ), ref Velocity, Smoothing);
        transform.position = Vector3.SmoothDamp(transform.position, Target.transform.TransformPoint(new Vector3(OffsetX, OffsetY, -1.0f)) + Vector3.back * OffsetZ, ref Velocity, Smoothing);

        //GetComponent<Transform>().position = Target.GetComponent<Transform>().position + _offset + (Vector3.back * OffsetZ);
        //GetComponent<Transform>().position = Target.GetComponent<Transform>().position + _offset + (Vector3.back * OffsetZ);
    }
}
