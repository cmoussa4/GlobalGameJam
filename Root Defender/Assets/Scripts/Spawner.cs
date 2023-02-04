using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Pebbles;
    private float spawnIntervals;
    private float spawnTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        spawnIntervals = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(-11, 11);
        spawnTime += Time.deltaTime;
        if (spawnTime >= 2.0f)
        {
            spawnTime = spawnIntervals;
            Instantiate(Pebbles, new Vector3(x, 5.0f, 0.0f), Quaternion.identity);
        }
    }
}
