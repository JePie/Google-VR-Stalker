using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seePlayer : MonoBehaviour {
	public Light spotLight;
	public float viewDistance;
	public LayerMask viewMask;
	float viewAngle;
	Transform target;

	public float speed = 5f;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		viewAngle = spotLight.spotAngle;
	}
	
	// Update is called once per frame
	void Update () {
		if (CanSeeTarget ()) {
			transform.LookAt (target.position);
			transform.Rotate(new Vector3 (0, 0, 0),Space.Self);
			Vector3 dir = target.position - transform.position;
			float distancethis = speed * Time.deltaTime;
			transform.Translate (dir.normalized * distancethis, Space.World);

		}
	}
	bool CanSeeTarget(){
		if (Vector3.Distance (transform.position, target.position) < viewDistance) {
			Vector3 dirToTarget = (target.position - transform.position).normalized;
			float angle = Vector3.Angle (transform.forward, dirToTarget);
			if (angle < viewAngle/2f) {
				if (!Physics.Linecast (transform.position, target.position, viewMask))
					return true;
			}
		}
		return false;
	}
}
