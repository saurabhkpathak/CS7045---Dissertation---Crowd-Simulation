using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentSample : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;
	System.Random r;
    float speedCache;
	// Use this for initialization
	void Start () {
		r = new System.Random ();
        agent = GetComponent<NavMeshAgent>();
		int rDest = r.Next (1, 11);
		agent.transform.position = GameObject.Find ("Destination " + rDest).GetComponent<Transform> ().position;
        speedCache = agent.speed;
    }
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(agent.transform.position, target.transform.position) < 1.5) {
			Debug.Log("objects touching");
			int rDest = r.Next (1, 11);
			target = GameObject.Find ("Destination " + rDest).GetComponent<Transform> ();
		}
        agent.SetDestination(target.position);
        if (Input.GetKeyDown("s"))
        {
            agent.speed = 0;
        }
        if (Input.GetKeyDown("m"))
        {
            agent.speed = speedCache;
        }
    }
}
