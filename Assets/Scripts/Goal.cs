using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int ScorePoints = 100;
    public float rotateSpeed = 50f;
    public float speed;
    void Update()
    {
        //transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag(Constants.PlayerTag))
        {
            GameManager.Instance.IncreaseScore(ScorePoints);
            Destroy(this.gameObject);
        }
    }
}
