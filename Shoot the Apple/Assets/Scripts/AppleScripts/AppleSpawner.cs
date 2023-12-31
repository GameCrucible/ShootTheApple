using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject apple;
    public int calls = 0;
    public int appleCount;

    void Start()
    {
        Invoke("SpawnApple", 0f);
    }

    void SpawnApple()
    {
        calls++;
        appleCount = Random.Range(calls, 4);
        int side = Random.Range(0,2) * 2 - 1;
        Instantiate(apple, new Vector2((11.5f * side), Random.Range(-4f,-6f)), Quaternion.identity);
    }

}
