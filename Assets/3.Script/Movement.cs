using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
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

        float fallSpeed = rigidBody.velocity.y;

        Vector3 velocity = new Vector3(x_Axis, 0, z_Axis);

        velocity *= speed; 
        velocity.y *= fallSpeed; // Initialize gravity

        rigidBody.velocity = velocity; 
    }
}
