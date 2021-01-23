using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed = 15f;
    public float mapWidth = 5f;
    private Rigidbody2D rb;

    public Text score;
    public static int scoreValue = 0;
    public Text winText;
    public AudioSource musicSource;
    //public AudioSource musicSource2;
    //public AudioClip musicClipThree;
    public AudioClip musicClipFour;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        winText.text = "";
        SetScoreText();

    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bear")
        {
            Destroy(collision.collider.gameObject);
            scoreValue += 1;
            SetScoreText();
            musicSource.clip = musicClipFour;
            musicSource.Play();
        }

    }

    void SetScoreText()
    {
        score.text = "Score: " + scoreValue.ToString();


        //if (scoreValue >= 15)
        // {
        //     musicSource.clip = musicClipThree;
        //   musicSource.Play();
        //  winText.text = "You win! Press R to restart! ";
        //Time.timeScale = 0;






    }
}