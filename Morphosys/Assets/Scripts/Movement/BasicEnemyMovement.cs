using UnityEngine;

public class BasicEnemyMovement : MonoBehaviour
{
    private GameObject Target;
    private Vector2 TargetVector;

    [Range(1.0f, 100.0f)]
    public float SpeedMultiplier = 1.0f;

    [Range(1.0f, 100.0f)]
    public float SensorRange = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TargetVector = Target.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Geometry.EuclideanDistance2D(Target.transform.position, transform.position) < SensorRange)
        {
            if (TargetVector.x > -1f)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0f, 180f, 0f));
                transform.Translate(Vector3.left * Time.deltaTime * SpeedMultiplier, Space.Self);
            }
            if (TargetVector.x < 1f)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0f, 0, 0f));
                transform.Translate(Vector3.left * Time.deltaTime * SpeedMultiplier, Space.Self);
            }
        }
    }
}
