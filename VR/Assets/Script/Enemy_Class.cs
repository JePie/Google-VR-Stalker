using UnityEngine;
using System.Collections;

public class EnemyArea: Monobehaviour {

	public BoxCollider area;
	GameObject player;
	bool playerInArea;
	
	public GameObject enemy;
	Basicenemy basicenemy;
	
	void start () {
		
		player = GameObject.findGameObjectwithTag ("player");
		baicenemy = enemy.GetComponent <BasicEnemy> (); 
		playerInArea = true;
		
	}//start
	
	void update () {
			if (playerInArea == true)
			{
				basicenemy.MoveToPlayer();
			}//POA true 
			if (playerInArea == false)
			{
				basicenemy.wander();
			}// POA false 
	}//update
	
	void OnTriggerEnter(Collider other) {
		if (other.gameObject == player)
		{
			playerInArea == true;
		}
		if (other.gameObject = player)
		{
			playerInArea = false;
		}
	}// ontriggerenter
	
	
	
	

}//class