using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public int hp;
	//private int originalHP;
	void Start(){
		//originalHP = hp;
	}

	void OnTriggerEnter(Collider otherObject){
		if(otherObject.gameObject.CompareTag("Player")){
			hp -= 1;
			if(hp == 0){
				gameObject.SetActive(false);
			}
		}
	}

	void Update(){
		
	}
}
