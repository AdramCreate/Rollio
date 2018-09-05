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
	private Scene currentLevel;

	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag("enemy");
		numEnemies = enemies.Length;
		currentLevel = SceneManager.GetActiveScene();
	}
	
	// Update is called once per frame
	void Update () {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        numEnemies = enemies.Length;
		setText();
		if(Input.GetKey(KeyCode.R)){
			SceneManager.LoadScene(currentLevel.name);
		}
	}

	void setText(){
		countText.text = "Enemies Left = " + numEnemies;
		if(numEnemies == 0){
			//SceneManager.LoadScene("Level2");
		}
	}
}
