using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameManager gm;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {

        if (gm.GameState == GameState.Dead)
        {
            gameObject.SetActive(false);
        }

        //if (gm.GameState == GameState.Playing)
        //{
        //    gameObject.SetActive(true);
        //}

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(0, 0, -moveHorizontal);

        rb.AddForce(movement * speed);
    }
}
