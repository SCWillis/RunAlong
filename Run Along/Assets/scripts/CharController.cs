using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {

    [SerializeField]
    float moveSpeed = 4f;
    Vector3 forward, right;

    [SerializeField]
    int maxJumps = 1;
    int jumps;

    [SerializeField]
    Terrain terrain;
    TerrainCollider tCollider;

	void Start () {

        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

        tCollider = terrain.GetComponent<TerrainCollider>();
        jumps = maxJumps;

	}
	
	void Update ()
    {
        if (Input.anyKey)
        {
            Move();
            Jump();
        }
        
	}

    void Move()
    {


        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey");
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        if (heading != Vector3.zero)
        {
            transform.forward = heading;
        }
        transform.position += rightMovement;
        transform.position += upMovement;
        
    }

    // 
    // Jump works but get a console error when jumping that i need to fix
    //
    void Jump()
    {
        if(Input.GetKeyDown("space") && jumps > 0)
        {
            //Vector3 jumpVector = new Vector3(0, 1, 0);
            //transform.position += jumpVector;
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
            jumps -= 1;
            Debug.Log(jumps);
            

        }
    }
    
    private void OnTriggerEnter(Collider collider)
    {
        if(collider == tCollider)
        {
            jumps = maxJumps;
            //Debug.Log("collide");
        }
    }
    

}





