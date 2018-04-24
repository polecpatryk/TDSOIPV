using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class PlayerController : MonoBehaviour
{
    private NavMeshAgent navAgent;
    private LayerMask movementMask;

	void Start ()
    {
        navAgent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
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
