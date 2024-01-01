using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleShootScript : MonoBehaviour
{
    //public variable
    public GameObject manager;
    public ParticleSystem slices;

    void Awake()
    { //done on initialization
        manager = GameObject.Find("GameManager");
    }

    public void OnMouseDown()
    {
        manager.GetComponent<ShootManager>().IncreaseScore();
        Instantiate(slices, this.transform.position, Quaternion.identity);
        slices.Play();
        Destroy(this.gameObject);
    }
}
