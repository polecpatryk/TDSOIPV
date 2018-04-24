using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector3 offset = new Vector3(1.8f, -1.2f, 0.0f);

    public float zoomSpeed = 15f;
    public float zoomMin = 2f;
    public float zoomMax = 40f;

    public float pitch = 2f;

    public float yawSpeed = 150f;

    private float currentZoom = 15f;
    private float currentYawHorizontal = 0f;

    void Start()
    {

    }
	
    void Update()
    {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        currentZoom = Mathf.Clamp(currentZoom, zoomMin, zoomMax);

        currentYawHorizontal -= Input.GetAxis("Horizontal") * yawSpeed * Time.deltaTime;
    }

	void LateUpdate ()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);

        transform.RotateAround(target.position, Vector3.up, currentYawHorizontal);
    }
}
