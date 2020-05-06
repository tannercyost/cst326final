using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    private float lifeTime = 2f;

    void DestroyObject()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EndCap"))
            Invoke("DestroyObject", lifeTime);
    }
}
