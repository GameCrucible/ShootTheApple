using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolRotate : MonoBehaviour
{
    private void FixedUpdate()
    {
        //Aim player at mouse
        //which direction is up
        Vector3 upAxis = new Vector3(0, -1, 0);
        Vector3 mouseScreenPosition = Input.mousePosition;
        //set mouses z to your targets
        mouseScreenPosition.y = transform.position.y;
        Vector3 mouseWorldSpace = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        transform.LookAt(mouseWorldSpace, upAxis);
        //zero out all rotations except the axis I want
        transform.eulerAngles = new Vector3(-90, -transform.eulerAngles.y, 0);
    }

}
