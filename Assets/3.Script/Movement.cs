using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rigidBody;

    float x_Axis, z_Axis;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        x_Axis = Input.GetAxis("Horizontal");
        z_Axis = Input.GetAxis("Vertical");

        rigidBody.velocity = new Vector3(x_Axis, -1f, z_Axis); 

    }
}
