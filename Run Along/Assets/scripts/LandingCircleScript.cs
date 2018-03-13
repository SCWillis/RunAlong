using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingCircleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(Random.Range(3f, 47f), 0, Random.Range(3f, 47f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
