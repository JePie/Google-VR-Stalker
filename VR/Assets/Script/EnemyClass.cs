using UnityEngine;
using System.Collections;

public class EnemyClass : MonoBehaviour {

	public BoxCollider area;
	GameObject player;
	bool playerInArea;
	
	public GameObject enemy;
	BasicEnemy basicenemy;
	
	void start () {
		
		player = GameObject.FindGameObjectWithTag ("player");
		basicenemy = enemy.GetComponent <BasicEnemy> (); 
		playerInArea = true;
		
	}//start
	
	void update () {
			if (playerInArea == true)
			{
			basicenemy.MovetoPlayer();
			}//POA true 
			if (playerInArea == false)
			{
				basicenemy.Wander();
			}// POA false 
	}//update
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player)
		{
			playerInArea = true;
		}
		if (other.gameObject == player)
		{
			playerInArea = false;
		}
	}// ontriggerenter
	
	
	
	

}//class