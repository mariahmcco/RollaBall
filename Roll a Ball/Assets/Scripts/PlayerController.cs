using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    private int score;
    public Text scoreText;

     public Text lifeText;
     private int life;

    public Text loseText;

    public AudioClip goodShell;

    public AudioClip badShell;

    public AudioSource MusicSource;

     private GameObject myPlayer;
     public Vector3 pos;


    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText ();
        winText.text = "";
        score = 0;
        setScoreText ();
        life = 3;
        setLifeText ();
        loseText.text = "";
        myPlayer = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);

        if (Input.GetKey("escape"))
             Application.Quit();
 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            setCountText ();
            score = score + 1;
            setScoreText ();
             MusicSource.PlayOneShot(goodShell);
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive (false);
            life = life - 1;
            setLifeText ();
             MusicSource.PlayOneShot(badShell);
        }

    }

    void setCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count == 10)
        {
            transform.position = pos;
        }

    }

    void setLifeText ()
    {
        lifeText.text = "Lives: " + life.ToString ();
        if (life <= 0)
        {
            loseText.text = "You Lost.";
            Destroy(myPlayer);

        }
    }

     void setScoreText ()
    {
        scoreText.text = "Score: " + score.ToString ();
        if (score >=18)
        {
            winText.text = "You Win!";
        }
    }
  
}