using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointRotation : MonoBehaviour
{
    public float rotationAngle = 90f; // The angle by which the character will be rotated
    int counter = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("doctor-waypoint1"))
        {
            counter++;
            if (counter == 1)
            {
                transform.Rotate(0, rotationAngle, 0);
            }
        }
    }
}
