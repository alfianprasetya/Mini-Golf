using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float force;

    Vector3 direction;
    void Update()
    {
        direction = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical"));
    }

    void FixedUpdate() 
    {
        if(direction == Vector3.zero)
            return;

        rb.AddForce(direction * force); 

    }
}
