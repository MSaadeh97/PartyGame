using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClipSeven;

    public int score;

    void Start()
    {
        musicSource.clip = musicClipSeven;

        //musicSource.PlayDelayed(12.0f);
        MyAudio();
    }



    void LateUpdate()
    {
        

        score = Player.scoreValue;
        

       
    }

    void MyAudio()
    {
        if (score == 15)
        {
            musicSource.Play();
        }
    }
}
