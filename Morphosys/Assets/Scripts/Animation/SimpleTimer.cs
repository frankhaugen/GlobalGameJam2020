using UnityEngine;

public class SimpleTimer : MonoBehaviour
{
    public float TargetTime = 60.0f;

    void Update()
    {
        TargetTime -= Time.deltaTime;

        if (TargetTime <= 0.0f)
        {
            TimerEnded();
        }
    }

    void TimerEnded()
    {
        //do your stuff here.
    }
}