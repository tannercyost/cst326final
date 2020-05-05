using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float damage = 1.0f;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == Constants.PlayerTag)
        {
            GameManager.Instance.Damage(damage);
            Debug.Log("Damage");
        }
    }
}
