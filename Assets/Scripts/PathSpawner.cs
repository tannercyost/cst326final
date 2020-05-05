using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawner : MonoBehaviour
{
    public GameObject pathPrefab;
    private bool fired;
    void Awake()
    {
        fired = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!fired)
        {
            GameObject newPath = Instantiate(pathPrefab,
                new Vector3(transform.position.x + 12f, transform.position.y, transform.position.z),
                new Quaternion(0f, 0f, 0f, 0f));
            //Object newPath = UnityEditor.PrefabUtility.InstantiatePrefab(pathPrefab as GameObject);

            fired = true;
        }
        
    }
}
