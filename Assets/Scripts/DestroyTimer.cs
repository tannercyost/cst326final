using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float LifeTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", LifeTime);
    }

    void DestroyObject()
    {
        if (GameManager.Instance.GameState != GameState.Dead)
        {
            Destroy(gameObject);
        }
    }
}
