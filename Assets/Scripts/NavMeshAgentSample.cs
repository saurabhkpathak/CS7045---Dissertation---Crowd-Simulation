using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class NavMeshAgentSample : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;
	System.Random r;
	// Use this for initialization
	void Start () {
		r = new System.Random ();
        agent = GetComponent<NavMeshAgent>();
		int rDest = r.Next (1, 11);
		agent.transform.position = GameObject.Find ("Destination " + rDest).GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(agent.transform.position, target.transform.position) < 1.5) {
			Debug.Log("objects touching");
			int rDest = r.Next (1, 11);
			target = GameObject.Find ("Destination " + rDest).GetComponent<Transform> ();
		}
        agent.SetDestination(target.position);
	}
}
