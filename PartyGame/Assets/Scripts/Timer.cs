using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    int countDownStartValue = 5;
    public Text timerText;
    
    public AudioSource musicSource;
    public AudioClip musicClipThree;
    public AudioClip musicClipFive;
    public int score;

    void Start()
    {
        countDownTimer();
    }
    void LateUpdate()
    {
        score = Player.scoreValue;
        


    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {

            timerText.text = "Timer : " + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
            if (score >= 15 )
            {
                timerText.text = "You win! ";

                Time.timeScale = 0;
                musicSource.clip = musicClipThree;
                musicSource.Play();

               
                
                

            }
        }
         
        else
        {
            timerText.text = "Times up! You ran out of time! ";

            Time.timeScale = 0;
            musicSource.clip = musicClipFive;
            musicSource.Play();
        }
       }
    }



