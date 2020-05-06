using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int ScorePoints = 100;
    public float rotateSpeed = 50f;
    public GameObject gm;
    private GameManager gmS;

    private void Awake()
    {
        gm = GameObject.Find("GameManager");
        gmS = gm.GetComponent<GameManager>();
    }
    private void Update()
    {
        //transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
        transform.Translate(Vector3.left * gmS.globalSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag(Constants.PlayerTag))
        {
            GameManager.Instance.IncreaseScore(ScorePoints);
            Destroy(this.gameObject);
        }
    }
}
