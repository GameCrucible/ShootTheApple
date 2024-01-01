using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleThrow : MonoBehaviour
{
    private Rigidbody2D rb2D;

    void Awake()
    { //done on initialization
        float direction = 1;
        if (this.gameObject.transform.position.x > 0)
        {
            direction = -1;
        }
        Vector2 force = new Vector2((((Random.Range(5, 9)) * 50) * direction), (300 + (300 * this.gameObject.transform.position.y / (-4))));
        rb2D = gameObject.GetComponent<Rigidbody2D>(); //assigns rigidbody to code
        rb2D.AddForce(force); //350, 600 base
    }

}
