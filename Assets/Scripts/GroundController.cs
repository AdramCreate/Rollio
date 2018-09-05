using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GroundController : MonoBehaviour {

	public int speed;
	public Text countText;
	private GameObject [] enemies;
	private int numEnemies;

	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag("enemy");
		numEnemies = enemies.Length;
	}
	
	// Update is called once per frame
	void Update () {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        numEnemies = enemies.Length;
		setText();
	}

	void setText(){
		countText.text = "Enemies Left = " + numEnemies;
		if(numEnemies == 0){
			//SceneManager.LoadScene("Level2");
		}
	}
}
