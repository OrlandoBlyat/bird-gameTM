using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate;
    private float timer;
    public float heightOffset;
    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer = timer + Time.deltaTime;
        }
        else {
            Spawn();
            timer = 0;
        }
    }

    void Spawn() {
        float maxHeight = transform.position.y + heightOffset;
        float minHeight = transform.position.y - heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(minHeight, maxHeight), 0), transform.rotation);
    }
}
