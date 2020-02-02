using System.Collections;
using UnityEngine;

public class SpriteFade : MonoBehaviour
{
    public float TargetTime = 60.0f;

    void Update()
    {
        TargetTime -= Time.deltaTime;

        if (TargetTime <= 0.0f)
        {
            //TimerEnded();
        }
    }
    public static IEnumerator FadeOut(SpriteRenderer sprite, float FadeTime)
    {
        float startAlpha = 0.2f;



        while (sprite.color.a > 0.0f)
        {
                        

            yield return null;
        }
    }
}
