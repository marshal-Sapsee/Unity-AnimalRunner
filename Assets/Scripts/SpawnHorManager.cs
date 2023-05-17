using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHorManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeZ = 15.0f;
    private float spawnPoseX = -25.0f;
    private float startDelay = 2;
    private float spawnInterval = 4.5f;

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
        Vector3 spawnPose = new Vector3(spawnPoseX, 0, Random.Range(0, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPose,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
