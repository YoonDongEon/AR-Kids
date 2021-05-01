using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicsource;
    public AudioSource touchsource;

    public void SetMusicVolume(float volume)
    {
        musicsource.volume = volume;
    }

    public void SetTouchVolume(float volume)
    {
        touchsource.volume = volume;
    }

    public void OnSfx()
    {
        musicsource.Pause();
        touchsource.Pause();
    }

    void Update()
    {

    }
}
