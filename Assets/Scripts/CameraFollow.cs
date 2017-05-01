using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float transitionSpeed = 0.2f;
	Camera myCam;

	// Use this for initialization
	void Start () {
		myCam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		myCam.orthographicSize = (Screen.height / 100f) / 6f;
		if (target) {
			transform.position = (Vector3.Lerp (transform.position, target.position, transitionSpeed) + new Vector3(0, 0, -10));
		}
	}
}
