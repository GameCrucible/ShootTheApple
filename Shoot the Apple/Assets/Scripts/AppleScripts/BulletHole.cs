using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class BulletHole : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Invoke("Delete",8.0f);
    }

    // Update is called once per frame
    void Delete()
    {
        Destroy(this.gameObject);
    }
}
