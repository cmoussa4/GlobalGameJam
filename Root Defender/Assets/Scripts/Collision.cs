using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    private int score;
    private bool dropletHeld = false;
    SpriteRenderer spriteRenderer;
    [SerializeField] TMP_Text Score;
    [SerializeField] TMP_Text holdingDroplet;
    [SerializeField] GameObject scorePopup;
    [SerializeField] GameObject Roots;
    [SerializeField] GameObject DropletExplosion;
    [SerializeField] AudioSource dropletSplash;
    [SerializeField] AudioSource pointSound;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        Score.text = "Score: ";
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Water droplets fed to the roots: " + score + "/20";

        if(dropletHeld)
        {
            holdingDroplet.text = "Holding Droplet";
        }
        else
        {
            holdingDroplet.text = "No Droplet Held";
        }

        ScoreUnlocks();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Droplet") && !dropletHeld)
        {
            Destroy(collision.gameObject);
            dropletHeld = true;
            Instantiate(DropletExplosion, collision.gameObject.transform.position, Quaternion.identity);
            spriteRenderer.color = Color.magenta;
            dropletSplash.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Roots") && dropletHeld)
        {
            
            dropletHeld = false;
            Instantiate(scorePopup, Roots.transform.position, Quaternion.identity);
            score++;
            spriteRenderer.color = Color.white;
            pointSound.time = 0.5f;
            pointSound.Play();
        }
    }

    void ScoreUnlocks()
    {
        if(score == 1)
        {
            SceneManager.LoadScene(3);
        }
    }
}
