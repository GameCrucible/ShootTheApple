using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryBox : MonoBehaviour
{
    public GameObject manager;

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("touched");
        Destroy(col.gameObject);
        manager.GetComponent<ShootManager>().DecreaseScore();
    }
}
