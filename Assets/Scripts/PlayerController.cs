using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class PlayerController : MonoBehaviour
{
    private Camera camera;
    private NavMeshAgent navAgent;
    private LayerMask movementMask;

	void Start ()
    {
        camera = Camera.main;
        navAgent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                MoveToPoint(hit.point);
                Debug.Log(hit.collider.tag);
            }
        }
	}

    void MoveToPoint(Vector3 _point)
    {
        navAgent.SetDestination(_point);
    }
}
