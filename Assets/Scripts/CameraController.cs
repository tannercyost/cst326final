using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private Transform sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere = player.transform.GetChild(0);
        offset = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(sphere.position.x + offset.x, transform.position.y, transform.position.z);
    }
}
