using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GroundController : MonoBehaviour {

	public int speed;
    public Text countText, levelText, winText;
    private GameObject[] enemies, TitleText;
	private int numEnemies;
	private Scene currentLevel;
    private float loadNextLevelTimer = 2.0f;
    private bool readyNextLevel = false;

	// Use this for initialization
	void Start () {
		enemies = GameObject.FindGameObjectsWithTag("enemy");
		numEnemies = enemies.Length;
		currentLevel = SceneManager.GetActiveScene();
        levelText.text = currentLevel.name;
        winText.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        enemies = GameObject.FindGameObjectsWithTag("enemy");
        numEnemies = enemies.Length;
		setEnemyText();

		if(Input.GetKey(KeyCode.R)){
			SceneManager.LoadScene(currentLevel.name);
		}
		if(Input.GetKey(KeyCode.Alpha1)){
			SceneManager.LoadScene("Level 1");
		}
		if(Input.GetKey(KeyCode.Alpha2)){
			SceneManager.LoadScene("Level 2");
		}
		if(Input.GetKey(KeyCode.Alpha3)){
			SceneManager.LoadScene("Level 3");
		}
		if(Input.GetKey(KeyCode.Alpha4)){
			SceneManager.LoadScene("Level 4");
		}
        if (Input.GetKey(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("Level 5");
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("Level 6");
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            SceneManager.LoadScene("Level 7");
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            SceneManager.LoadScene("Level 8");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (readyNextLevel)
        {
            loadNextLevelTimer -= Time.deltaTime;
        }
        if(loadNextLevelTimer <= 0)
        {
            loadNextLevel();
        }
	}

	void setEnemyText(){
		countText.text = "Enemies Left = " + numEnemies;
        if(numEnemies == 0)
        {
            TitleText = GameObject.FindGameObjectsWithTag("TitleText");
            if (TitleText != null)
            {
                foreach(GameObject text in TitleText)
                {
                    text.gameObject.SetActive(false);
                }
            }

            winText.gameObject.SetActive(true);
            if (currentLevel.name != "Level 8")
            {
                readyNextLevel = true;
            }
        }
	}

    void loadNextLevel()
    {
        if(currentLevel.name == "Level 1")
        {
            SceneManager.LoadScene("Level 2");
        }
        else if (currentLevel.name == "Level 2")
        {
            SceneManager.LoadScene("Level 3");
        }
        else if (currentLevel.name == "Level 3")
        {
            SceneManager.LoadScene("Level 4");
        }
        else if (currentLevel.name == "Level 4")
        {
            SceneManager.LoadScene("Level 5");
        }
        else if (currentLevel.name == "Level 5")
        {
            SceneManager.LoadScene("Level 6");
        }
        else if (currentLevel.name == "Level 6")
        {
            SceneManager.LoadScene("Level 7");
        }
        else if (currentLevel.name == "Level 7")
        {
            SceneManager.LoadScene("Level 8");
        }
    }
}
