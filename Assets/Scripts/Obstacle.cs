using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float damage = 1.0f;
    public GameObject gm;
    private GameManager gmS;

    private void Awake()
    {
        gm = GameObject.Find("GameManager");
        gmS = gm.GetComponent<GameManager>();
    }
    private void Update()
    {
        transform.Translate(Vector3.left * gmS.globalSpeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == Constants.PlayerTag)
        {
            GameManager.Instance.Damage(damage);
            Destroy(gameObject);
        }
    }
}
