using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> rows;
    private List<Transform> childs;
    public GameObject temp;
    // Start is called before the first frame update
    void Start()
    {
        childs = new List<Transform>();
        GetAllChildren(transform, ref childs);
        //foreach (GameObject item in rows)
        //{
        //    Debug.Log(item);
        //}

        foreach (Transform item in childs)
        {
            Instantiate(temp, item);
        }
        Debug.Log("Instance!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private static void GetAllChildren(Transform parent, ref List<Transform> transforms)
    {

        foreach (Transform t in parent)
        {
            Debug.Log(t);
            transforms.Add(t);

            GetAllChildren(t, ref transforms);

        }

    }
}
