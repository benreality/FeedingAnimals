using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalsPrefabs;
    private float spawnX = 20;
    private float spawnZ = 20;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.S))
        {

            SpawnRandomAnimal();

        }
    }
  // Spawn Random Animals
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);

        int animalIndex = Random.Range(0, animalsPrefabs.Length);
        Instantiate(animalsPrefabs[animalIndex], spawnPos, animalsPrefabs[animalIndex].transform.rotation);


    }
}
