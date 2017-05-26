using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {

	public float sensorLength = 5.0f;
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * speed * Time.deltaTime;
	}

	void OnDrawGizmos () {
		Gizmos.DrawRay (transform.position, transform.forward * (sensorLength + transform.localScale.z));
		Gizmos.DrawRay (transform.position, -transform.forward * (sensorLength + transform.localScale.z));
		Gizmos.DrawRay (transform.position, transform.right * (sensorLength + transform.localScale.x));
		Gizmos.DrawRay (transform.position, -transform.right * (sensorLength + transform.localScale.x));
	}
}
