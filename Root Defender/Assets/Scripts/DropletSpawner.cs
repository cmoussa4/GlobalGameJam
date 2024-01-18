using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropletSpawner : MonoBehaviour
{
    [SerializeField] GameObject Droplet;
    private float spawnIntervals;
    private float spawnTime = 0f;
    [SerializeField] float timepassedforSpawning;
    [SerializeField] Transform[] dropletSpawns;
    // Start is called before the first frame update
    void Start()
    {
        spawnIntervals = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {

        spawnTime += Time.deltaTime;
        if(spawnTime >= timepassedforSpawning)
        {
            spawnTime = spawnIntervals;
            Instantiate(Droplet, dropletSpawns[Random.Range(0, dropletSpawns.Length-1)].position, Quaternion.identity);
        }
    }
}
