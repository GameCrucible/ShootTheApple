using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleToss : MonoBehaviour
{
    private Rigidbody2D rb2D;

    void Awake()
    { //done on initialization
        Vector2 force = new Vector2(0, 50 * Random.Range(16,22));
        rb2D = gameObject.GetComponent<Rigidbody2D>(); //assigns rigidbody to code
        rb2D.AddForce(force);
    }
}
