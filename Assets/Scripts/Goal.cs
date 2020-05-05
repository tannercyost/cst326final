﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int ScorePoints = 100;
    public float rotateSpeed = 50f;
    void Update()
    {
        transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
    }

    void OnTriggerEnter(Collider col)
    {
        GameManager.Instance.IncreaseScore(ScorePoints);
        Destroy(this.gameObject);
    }

}
