using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float xOffset, yOffset, zOffset;

    public void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(player.transform.position);
    }

    
}
