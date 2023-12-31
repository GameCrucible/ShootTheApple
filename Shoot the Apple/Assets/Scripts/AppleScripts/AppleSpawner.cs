using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    public GameObject apple;
    public int appleCount;
    public float[] yRange;

    void Start()
    {
        Invoke("SpawnApple", 0f);
    }

    void SpawnApple()
    {
        appleCount = Random.Range(1, 4);
        for (int i = 0; i < appleCount; i++)
        {
            int side = Random.Range(0, 2) * 2 - 1;
            int randomIndex = Random.Range(0,3);
            Instantiate(apple, new Vector2((11.5f * side), yRange[randomIndex]), Quaternion.identity);
        }
        Invoke("SpawnApple", 2f);

    }

}
