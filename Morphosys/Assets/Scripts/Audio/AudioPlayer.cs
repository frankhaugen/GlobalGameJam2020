using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Range(1.0f, 10.0f)] public float FadeInTime = 1.0f;
    [Range(1.0f, 10.0f)] public float FadeOutTime = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AudioFade.FadeIn(GetComponent<AudioSource>(), FadeInTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
