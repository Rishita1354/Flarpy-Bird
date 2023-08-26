using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudspawnerscript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 3;
    private float timer = 0;
    public float heightoffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnClouds();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnClouds();
            timer = 0;
        }
    }
    void spawnClouds()
    {
        float lowestPoint = transform.position.y - heightoffset;
        float highestPoint = transform.position.y + heightoffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}

