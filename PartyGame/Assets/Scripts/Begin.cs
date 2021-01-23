using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClipOne;
    

    void Start()
    {
        musicSource.clip = musicClipOne;
        musicSource.Play();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

