using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    private float lifeTime = 2f;

    void DestroyObject()
    {
        if (GameManager.Instance.GameState != GameState.Dead)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.CompareTag("EndCap"))
            Invoke("DestroyObject", lifeTime);
    }
}
