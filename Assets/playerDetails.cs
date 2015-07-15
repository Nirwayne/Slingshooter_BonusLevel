using UnityEngine;
using System.Collections;

public class playerDetails : MonoBehaviour {
	public static playerDetails s;

	void Awake() {
		s = this;
	}

	public Vector3 GetPlayerPosition() {
		return transform.position;
	}



}
