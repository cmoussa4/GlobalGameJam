using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision : MonoBehaviour
{
    private int score = 0;
    private bool dropletHeld = false;
    SpriteRenderer spriteRenderer;
    [SerializeField] TextMeshProUGUI Score;
    [SerializeField] TextMeshProUGUI holdingDroplet;
    [SerializeField] GameObject scorePopup;
    [SerializeField] GameObject Roots;
    [SerializeField] GameObject DropletExplosion;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Water droplets fed to the roots: " + score;

        if(dropletHeld)
        {
            holdingDroplet.text = "Holding Droplet";
        }
        else
        {
            holdingDroplet.text = "No Droplet Held";
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Droplet") && !dropletHeld)
        {
            Destroy(collision.gameObject);
            dropletHeld = true;
            Instantiate(DropletExplosion, collision.gameObject.transform.position, Quaternion.identity);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Roots") && dropletHeld)
        {
            score++;
            dropletHeld = false;
            Instantiate(scorePopup, Roots.transform.position, Quaternion.identity);
        }
    }
}
