using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]

public class Wander : MonoBehaviour {

	public float speed = 3f;
	public float directionChangeInterval = 1;
	public float maxheadingChange = 30;
	
	CharacterController controller;
	float heading;
	Vector3 targetRotation;
	
	Vector3 forward
	{
		get 
		{
			return transform.TransformDirection(Vector3.forward);
		}
	}
	
	void Awake ()
	{
		controller = GetComponent <CharacterController>();
		
		heading = Random.Range(0,360);
		transform.eulerAngles = new Vector3 (0, heading,0);
		
		StartCoroutine(NewheadingRoutine());
	}
	
	void Update ()
	{
		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles,targetRotation, Time.deltaTime * directionChangeInterval);
		controller.SimpleMove(forward * speed);
	}
	
	void OnControllerColliderHit (ControllerColliderHit hit)
	{
		if (hit.gameObject.tag != "Boundary")
		{
			return;
		}
		
			var newDirection = Vector3.Reflect(forward,hit.normal);
			transform.rotation = Quaternion.FromToRotation(Vector3.forward,newDirection);
			heading = transform.eulerAngles.y;
			NewHeading();	
	}

	void NewHeading()
	{
		var floor = transform.eulerAngles.y - maxheadingChange;
		var ceil = transform.eulerAngles.y + maxheadingChange;
		heading = Random.Range(floor,ceil);
		targetRotation = new Vector3(0,heading,0);
	}
	
	IEnumerator NewheadingRoutine()
	{
		while (true)
		{
			yield return new WaitForSeconds(directionChangeInterval);
		}
	}
}//class