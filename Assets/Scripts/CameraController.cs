using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private Transform transformCamera;
    private GameObject player;

    void Start ()
    {
        transformCamera = GetComponent<Transform>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	void Update ()
    {
        transformCamera.position = player.transform.position + new Vector3(0.0f, 20.0f, -10.0f);
	}
}
