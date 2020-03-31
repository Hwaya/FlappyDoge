using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePool : MonoBehaviour
{
    public GameObject PipePrefab;

    public float spawnRate = 2.0f;

    public float pipeMin = -0.5f;
    public float pipeMax = 0.5f;

    float lastSpawnTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        lastSpawnTime += Time.deltaTime;
        
        if(lastSpawnTime >= spawnRate)
        {
            lastSpawnTime = 0;

            Vector2 objectPoolPosition = new Vector2(1.5f, Random.Range(pipeMin, pipeMax));

            Instantiate(PipePrefab, objectPoolPosition, Quaternion.identity);
        }
    }
}
