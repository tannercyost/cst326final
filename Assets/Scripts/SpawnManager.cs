using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject goal;
    public GameObject obstacle;
    private float timeToSpawn;
    public float startTimeToSpawn;
    public float spawnTimeDelta;
    public float minimumTime = 0.65f;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Spawn()
    {
        foreach (Transform t in transform)
        {
            if (Random.value > 0.70)
                Instantiate(goal, t);
            else if (Random.value > 0.70)
                Instantiate(obstacle, t);
        }
    }

    private void Update()
    {
        if (timeToSpawn <= 0)
        {
            Spawn();
            //Instantiate(obstacle, transform);
            timeToSpawn = startTimeToSpawn;
            if (startTimeToSpawn > minimumTime)
            {
                startTimeToSpawn -= spawnTimeDelta;
            }
        }
        else
        {
            timeToSpawn -= Time.deltaTime;
        }
    }
}
