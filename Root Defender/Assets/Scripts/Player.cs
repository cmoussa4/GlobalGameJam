using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float steerSpeed;
    [SerializeField] AudioSource audio;

    // Start is called before the first frame update
    private void Awake()
    {
        audio.Play();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Moving();
        
    }
    private void Update()
    {

    }
    void Moving()
    {
 
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed * Time.fixedDeltaTime;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.fixedDeltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, speedAmount, 0);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pebble"))
        {
            Destroy(this.gameObject);
            
        }
    }

}
