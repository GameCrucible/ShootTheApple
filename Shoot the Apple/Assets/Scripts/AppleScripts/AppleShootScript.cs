using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleShootScript : MonoBehaviour
{
    //public variable
    public GameObject manager;
    public ParticleSystem slices;

    //private variable
    private Rigidbody2D rb2D;

    void Awake()
    { //done on initialization
        manager = GameObject.Find("GameManager");
        float direction = 1;
        if(this.gameObject.transform.position.x < 0) {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
        Vector2 force = new Vector2((350 * direction), 600);
        rb2D = gameObject.GetComponent<Rigidbody2D>(); //assigns rigidbody to code
        rb2D.AddForce(force); //350, 600 base
    }

    public void OnMouseDown()
    {
        manager.GetComponent<ShootManager>().IncreaseScore();
        Instantiate(slices, this.transform.position, Quaternion.identity);
        slices.Play();
        Destroy(this.gameObject);
    }
}
