using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject apple;
    public GameObject[] throwSpawnLocation;
    public GameObject[] tossSpawnLocation;

    private GameObject sLoc, spLoc;

    void Start()
    {
        throwSpawnLocation = GameObject.FindGameObjectsWithTag("ThrowSpawn");
        tossSpawnLocation = GameObject.FindGameObjectsWithTag("TossSpawn");
        Invoke("SpawnThrowApple", 0f);
        Invoke("SpawnTossApple", 0f);

    }

    void SpawnThrowApple()
    {
        for (int i = 0; i < Random.Range(1, 4); i++)
        {
            sLoc = throwSpawnLocation[Random.Range(0, 6)];
            sLoc.GetComponent<AppleSpawnPoint>().SpawnApple();
        }
        Invoke("SpawnThrowApple", 2f);

    }

    void SpawnTossApple()
    {
        for(int i = 0; i < Random.Range(1,4); i++)
        {
            spLoc = tossSpawnLocation[Random.Range(0, 3)];
            spLoc.GetComponent<AppleSpawnPoint>().SpawnApple();
        }
    }

}
