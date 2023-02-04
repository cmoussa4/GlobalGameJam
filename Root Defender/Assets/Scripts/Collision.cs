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
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
