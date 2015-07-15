using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Character_controller : MonoBehaviour {

	public float moveSpeed;
	
	private Vector3 myPosition;
	private Vector2 oldMousePos;
	private Vector2 newMousePos;

	private float maxRotX;
	private float minRotX;

	void Awake() {
		myPosition = transform.position;
		oldMousePos = Input.mousePosition;
		newMousePos = Input.mousePosition;

		maxRotX = 60f;
		minRotX = -60f;

	}


	void FixedUpdate() {
		//Position Controller
		if (Input.GetKey("w")){
			myPosition += Vector3.forward * moveSpeed*Time.deltaTime;
		}
		if (Input.GetKey("s")){
			myPosition += Vector3.back * moveSpeed*Time.deltaTime;
		}
		if (Input.GetKey("a")){
			myPosition += Vector3.left * moveSpeed*Time.deltaTime;
		}
		if (Input.GetKey("d")){
			myPosition += Vector3.right * moveSpeed*Time.deltaTime;
		}
		transform.position = myPosition;

		//CameraRotation Controller
		//Vector3 newEulers = getMouseDelta().x, 0,0;
		//float eulerx = getMouseDelta().x;
		Vector3 myEulers = transform.eulerAngles;
		//myEulers.x -= getMouseDelta().y;
		myEulers.x -= getMouseDelta().y;

		myEulers.z = 0;
		transform.eulerAngles = myEulers;


	}

	Vector2 getMouseDelta() {
		Vector2 deltaOutput;
		newMousePos = Input.mousePosition;

		deltaOutput = newMousePos - oldMousePos;
		// could reset mouseposition
		oldMousePos = newMousePos;
		return deltaOutput;
	}


}
