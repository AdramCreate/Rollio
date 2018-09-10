using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleTextScript : MonoBehaviour {
    public float timeLeft = 3.0f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        
        if(timeLeft < 0)
        {
            Destroy(gameObject);
        }
	}
}
