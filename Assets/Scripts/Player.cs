using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    //public float Zincrement;
    private Rigidbody rb;
    //private Vector3 targetPos;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        //transform.position = Vector3.MoveTowards(transform.position, targetPos, 1f * Time.deltaTime);
        //if (Input.GetAxis("Horizontal") < 0) // left
        //{
        //    targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + Zincrement);
        //}
        //else if (Input.GetAxis("Horizontal") > 0) // right
        //{
        //    targetPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - Zincrement);
        //}


        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveVertical, 0, -moveHorizontal);

        rb.AddForce(movement * speed);
    }
}
