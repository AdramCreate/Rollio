using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public int speed;
	private Vector2 originalPosition;
	private Rigidbody rb;
	//private bool canJump;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		originalPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.R)){
			transform.position = originalPosition;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
		}
		if(Input.GetKey(KeyCode.Space)){
            //canJump = true;
		}
    }

	/*void OnTriggerEnter(Collider otherObject){
		if(otherObject.gameObject.CompareTag("enemy")){
			rb.AddForce(Vector3.forward, ForceMode.Impulse);
		}
	}*/

	/*void OnCollisionEnter(Collider otherObject){
		if(otherObject.gameObject.CompareTag("enemy")){
			rb.AddForce(new Vector3(0.0f,0.0f, 5f), ForceMode.Impulse);
		}
	}*/

    void FixedUpdate()
    {
        float moveAD = Input.GetAxis("Horizontal");
        float moveWS = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveWS, 0.0f, -moveAD);
        rb.AddForce(movement * speed);

		/*if(canJump){
			canJump = false;
			rb.AddForce(0.0f, 0.5f, 0.0f, ForceMode.Impulse);
		}*/
    }
}
