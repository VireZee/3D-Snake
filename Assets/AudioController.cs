using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;
    private AudioSource[] audioSources;
    public AudioClip[] sfxCollection;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        audioSources = GetComponents<AudioSource>();
    }
    public void PlayBGM()
    {
        audioSources[0].volume = 1;
    }
    public void StopBGM()
    {
        audioSources[0].volume = 0;
    }
    public void PlaySFX(int audioClipIndex)
    {
        audioSources[1].clip = sfxCollection[audioClipIndex];
        audioSources[1].Play();
    }
}