using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject target;
	public float damping = 1;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = target.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate(){
		//float desiredAngle = target.transform.eulerAngles.y;
		//Quaternion rotation = Quaternion.Euler(0, desiredAngle, 0);
	
		transform.position = target.transform.position - offset;//- (rotation * offset);
		//transform.LookAt(target.transform);
	}
}
