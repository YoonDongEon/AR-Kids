using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGM_Player : MonoBehaviour
{
    public AudioClip[] intro_music;
    AudioSource soundSource;

    void Start()
    {
        soundSource = GetComponent<AudioSource>();
        StartCoroutine("Playlist");
    }

    IEnumerator Playlist()
    {
        soundSource.clip = intro_music[0];
        soundSource.Play();
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            if (!soundSource.isPlaying && soundSource.clip.name == "시작배경음(요리시간)")
            {
                soundSource.volume = 1;
                soundSource.clip = intro_music[1];
                soundSource.Play();
            }
            else if (!soundSource.isPlaying && soundSource.clip.name == "시작배경음(토끼정원)")
            {
                soundSource.volume = 1;
                soundSource.clip = intro_music[2];
                soundSource.Play();
            }
            else if (!soundSource.isPlaying && soundSource.clip.name == "시작배경음(Carefree Melody)")
            {
                soundSource.volume = 1;
                soundSource.clip = intro_music[3];
                soundSource.Play();
            }
            else if (!soundSource.isPlaying && soundSource.clip.name == "시작배경음(Welsh Corgi)")
            {
                soundSource.volume = 1;
                soundSource.clip = intro_music[4];
                soundSource.Play();
            }
            else if (!soundSource.isPlaying && soundSource.clip.name == "시작배경음(장난감 마을)")
            {
                soundSource.volume = 1;
                soundSource.clip = intro_music[0];
                soundSource.Play();
            }

        }
    }

    public void SelectBGM1()
    {
            soundSource.clip = intro_music[0];
            soundSource.Play();
    }
    public void SelectBGM2()
    {
        soundSource.clip = intro_music[1];
        soundSource.Play();
    }
    public void SelectBGM3()
    {
        soundSource.clip = intro_music[2];
        soundSource.Play();
    }
    public void SelectBGM4()
    {
        soundSource.clip = intro_music[3];
        soundSource.Play();
    }
    public void SelectBGM5()
    {
        soundSource.clip = intro_music[4];
        soundSource.Play();
    }
}
