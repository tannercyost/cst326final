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

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (!fired)
        {
            Debug.Log("Enter");
            GameObject newPath = Instantiate(pathPrefab,
                new Vector3(transform.position.x + 5.25f, transform.position.y - 0.1f, transform.position.z),
                new Quaternion(0f, 0f, 0f, 0f)) as GameObject;
            //Object newPath = UnityEditor.PrefabUtility.InstantiatePrefab(pathPrefab as GameObject);

            fired = true;
        }
        
    }
}
