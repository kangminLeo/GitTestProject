using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private Vector3 direction;
    public float speed = 10f;
    public float jumpForce = 10f;
    private Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        direction = Vector3.right;
    }

    private void Update()
    {
        Move();
        
    }

    private void Move()
    {
        rigidBody.velocity = direction * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "Coin")
        {
            collision.gameObject.SetActive(false);
            GameManager.Score += 10;
        }

        if(collision.transform.name == "Obstacle")
        {
            //gameObject.SetActive(false);
            Destroy(gameObject);
            GameManager.isAlive = false;
        }

    }


}
