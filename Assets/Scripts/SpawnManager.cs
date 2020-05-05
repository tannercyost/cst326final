using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> rows;
    private List<Transform> childs;
    public GameObject goal;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform t in transform)
        {
            foreach (Transform item in t)
            {
                if (Random.value > 0.90)
                    Instantiate(goal, item);
                else if (Random.value > 0.90)
                    Instantiate(obstacle, item);
            }

        }
    }
}
