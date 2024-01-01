using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject[] throwSpawnLocation;
    public GameObject[] tossSpawnLocation;

    private bool stopApples = false;
    private GameObject sLoc, spLoc;

    void Start()
    {
        throwSpawnLocation = GameObject.FindGameObjectsWithTag("ThrowSpawn");
        tossSpawnLocation = GameObject.FindGameObjectsWithTag("TossSpawn");
        Invoke("SpawnThrowApple", 3f);
        Invoke("SpawnTossApple", 7f);
        Invoke("AppleShutDown", 13f);

    }

    void SpawnThrowApple()
    {
        Debug.Log("Apples Thrown");
        for (int i = 0; i < Random.Range(1, 4); i++)
        {
            sLoc = throwSpawnLocation[Random.Range(0, 6)];
            sLoc.GetComponent<AppleSpawnPoint>().SpawnApple();
        }
        if (!stopApples) { Invoke("SpawnThrowApple", 1.5f); }

    }

    void SpawnTossApple()
    {
        Debug.Log("Apples Tossed");
        for(int i = 0; i < Random.Range(1,4); i++)
        {
            spLoc = tossSpawnLocation[Random.Range(0, 3)];
            spLoc.GetComponent<AppleSpawnPoint>().SpawnApple();
        }
        if (!stopApples) {Invoke("SpawnTossApple", 2f);}
        
    }

    public void AppleShutDown()
    {
        stopApples = true;
    }
   

}
