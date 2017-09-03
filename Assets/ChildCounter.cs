using System.Diagnostics;
using UnityEngine;

public class ChildCounter : MonoBehaviour {
    Stopwatch timer;
    // Use this for initialization
    void Start () {
        timer = new Stopwatch();
        UnityEngine.Debug.Log(transform.childCount);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("e"))
        {
            timer.Start();
        }
        UnityEngine.Debug.Log(timer.ElapsedMilliseconds);
    }
}
