using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public int hp;
    public bool isDecreasing;
    public bool isTeleporting;
    public AudioSource damageSound;
    public AudioSource deathSound;
    private float deathLoadTimer = 0.3f;

	//private int originalHP;
	void Start(){
        //originalHP = hp;
        
	}

	void OnCollisionEnter(Collision otherObject){
        if (otherObject.gameObject.CompareTag("Player"))
        {
            hp -= 1;
            if (hp == 0)
            {
                transform.position = new Vector3(9999.9f, 9999.9f, 9999.9f);
                deathSound.Play();
                Destroy(gameObject, 1f);
            }
            else
            {
                damageSound.Play();

                if (isDecreasing)
                {
                    transform.localScale -= new Vector3(0.5f, 1f, 0.5f);
                }
                if (isTeleporting)
                {
                    transform.position = new Vector3(Random.Range(-13.0f, 13.0f), 1.5f, Random.Range(-13.0f, 13.0f));
                }
            }
        }
	}

	void Update(){

    }
}
