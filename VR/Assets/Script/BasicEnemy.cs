using UnityEngine;
using System.Collections;

public class BasicEnemy : MonoBehaviour {
	public Transform target;
	public float speed = 5f;
	public float attackRange = 1f;
	void Start() 
	{
		Wander();
	}//start
	
	void Update () {
		
	}
	
	public void MovetoPlayer() 
	{
	
	transform.LookAt (target.position);
	transform.Rotate(new Vector3 (0, -90, 0),Space.Self);
	
	
	if (Vector3.Distance(transform.position,target.position) > attackRange)
	{
		transform.Translate (new Vector3 (speed * Time.deltaTime,0,0));
	}
	
	}// movetoplayer

    public void Wander() { }
	//wander
}// class