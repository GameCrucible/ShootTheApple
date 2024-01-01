using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawnPoint : MonoBehaviour
{
    public GameObject apple;

    public void SpawnApple()
    {
        Instantiate(apple, this.gameObject.transform.position, Quaternion.identity);
    }
}
