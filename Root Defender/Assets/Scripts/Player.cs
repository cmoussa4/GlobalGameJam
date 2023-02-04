using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.1f;
    [SerializeField] float steerSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        
    }
    void Moving()
    {
        float speedAmount = Input.GetAxis("Vertical") * moveSpeed;
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;

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
