using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropletSpawner : MonoBehaviour
{
    [SerializeField] GameObject Droplet;
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
        float x = Random.Range(-8.0f, 8.0f);
        float y = Random.Range(-5.0f,1.5f);

        spawnTime += Time.deltaTime;
        if(spawnTime >= 2.0f)
        {
            spawnTime = spawnIntervals;
            Instantiate(Droplet, new Vector3(x, y, 0), Quaternion.identity);
        }
    }
}
