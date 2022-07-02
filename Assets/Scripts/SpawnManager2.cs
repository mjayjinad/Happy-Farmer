using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeZ = 12.0f;
    private float spawnPositionX = 15.0f;
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
        // Randomly generate animalIIndex and spawn position 
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(spawnPositionX, 0, Random.Range(0, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPosition, animalPrefabs[animalIndex].transform.rotation);
        
    }
   
}
