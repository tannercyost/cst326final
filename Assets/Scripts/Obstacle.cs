using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float damage = 1.0f;
    public float speed;
    void Update()
    {
        //transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == Constants.PlayerTag)
        {
            GameManager.Instance.Damage(damage);
            Destroy(gameObject);
            Debug.Log("Damage");
        }
    }
}
