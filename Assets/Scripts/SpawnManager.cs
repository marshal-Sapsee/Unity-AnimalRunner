using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 10.0f;
    private float spawnPoseZ = 20.0f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPose = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPoseZ);
        Instantiate(animalPrefabs[animalIndex], spawnPose,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
