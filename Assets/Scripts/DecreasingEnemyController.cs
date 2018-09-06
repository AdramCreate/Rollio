using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreasingEnemyController : MonoBehaviour {

	public int hp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision otherObject){
        if (otherObject.gameObject.CompareTag("Player"))
        {
            hp -= 1;
			transform.localScale -= new Vector3(0.05f, 0.1f, 0.05f);
            if (hp == 0)
            {
                gameObject.SetActive(false);
            }
        }
	}
}
