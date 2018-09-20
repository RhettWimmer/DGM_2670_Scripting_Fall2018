using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent((typeof(NavMeshAgent)))]
public class AIAgent : MonoBehaviour
{

	private NavMeshAgent agent;
	public Transform Target;
//	public bool CanChase;
	public Transform PostPoint;
	private Transform finalDestination;
	public FloatData Speed;
	
	private void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
		agent.speed = Speed.Value;
		finalDestination = transform;
	}

	private void OnTriggerEnter(Collider obj)
	{
		if (obj.transform == Target)
		finalDestination = Target;
	}

	private void OnTriggerExit(Collider obj)
	{
		finalDestination = PostPoint;
	}

	private void Update()
	{
		agent.destination = finalDestination.position;

	}
}
