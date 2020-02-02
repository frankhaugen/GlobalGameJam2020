using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    private AudioSource AudioSource;

    public List<SpriteRenderer> Sprites;

    [Range(1.0f, 10.0f)] public float FadeOutTime = 1.0f;
    [Range(1.0f, 100.0f)] public float AudioFadeTime = 1.0f;
    [Range(1.0f, 10.0f)] public float WaitForSeconds = 1.0f;


    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        StartCoroutine(RunSequence());
    }

    private IEnumerator RunSequence()
    {
        AudioSource.Play();
        AudioSource.volume = 0.0f;
        AudioSource.DOFade(1.0f, AudioFadeTime);
        foreach (var sprite in Sprites)
        {
            yield return new WaitForSeconds(WaitForSeconds);
            sprite.DOFade(0f, FadeOutTime);
        }
        AudioSource.DOFade(0.0f, WaitForSeconds);
        yield return new WaitForSeconds(WaitForSeconds);
        //SceneManager.LoadScene("");
    }
}
