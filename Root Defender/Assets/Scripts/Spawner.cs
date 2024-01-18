using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Pebbles;
    private float spawnIntervals;
    private float spawnTime = 0f;
    public float timeTillNextSpawn = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        spawnIntervals = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(-8.0f, 8.0f);
        spawnTime += Time.deltaTime;
        if (spawnTime >= timeTillNextSpawn)
        {
            spawnTime = spawnIntervals;
            Instantiate(Pebbles, new Vector3(x, 5.0f, 0.0f), Quaternion.identity);
            

        }
    }
}
