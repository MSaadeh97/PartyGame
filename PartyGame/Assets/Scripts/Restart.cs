using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public AudioSource musicSource;    
    public AudioClip musicClipSix;
    
    public int score; 

    void Start()
    {
        musicSource.clip = musicClipSix;
        musicSource.PlayDelayed(2.0f);
        
    }



    void Update()
    {
        

        score = Player.scoreValue;

        if (score == 16)
        {
            musicSource.mute = true;
            
        }
        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel(0);
            

    }
}
