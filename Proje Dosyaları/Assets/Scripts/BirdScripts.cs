using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdScripts : MonoBehaviour
{
    // Jump
    public float zýplama_aralýðý;
    Rigidbody2D rb;

    public AudioClip jumpSound;
    public AudioClip gameOverSound;
    public AudioClip scoreSound;

    // References

    public Text skor_text;
    public float skor;
    public GameObject ReplayBtn;
    public GameObject GameOver;
    public GameObject MoreGames;
    public GameObject Bird97;
    public GameObject Feedback;
    public GameObject YouTube;

    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        skor = 0;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * zýplama_aralýðý;
            SoundManager.instance.PlaySound(jumpSound);
        }

        skor_text.text = skor.ToString();
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag == "Scorer")
        {
            skor++;
            SoundManager.instance.PlaySound(scoreSound);
        }
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Pipe")
        {
            Time.timeScale = 0;
            Bird97.SetActive(true);
            Feedback.SetActive(true);
            MoreGames.SetActive(true);
            YouTube.SetActive(true);
            ReplayBtn.SetActive(true);
            GameOver.SetActive(true);
            SoundManager.instance.PlaySound(gameOverSound);
        }
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
