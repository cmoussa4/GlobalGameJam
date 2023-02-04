using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pebble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy();
    }
    void Destroy()
    {
        if(transform.position.y <= -5f)
        {
            Destroy(this.gameObject);
        }
    }
}
