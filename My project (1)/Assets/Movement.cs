using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    void Update()
    {
        if (Input.GetKey("up"))
        {
            rb.AddForce(0, 0, 1000 * Time.deltaTime);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -1000 * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            rb.AddForce(-1000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            rb.AddForce(1000 * Time.deltaTime, 0, 0);
        }
    }
}
