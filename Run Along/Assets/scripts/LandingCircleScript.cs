using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingCircleScript : MonoBehaviour {

    //[SerializeField]
    //GameObject box;

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(Random.Range(3f, 47f), 1, Random.Range(3f, 47f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider box)
    {
        Debug.Log("HIT");
    }
}
