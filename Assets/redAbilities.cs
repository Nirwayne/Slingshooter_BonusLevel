using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class redAbilities : MonoBehaviour {

	public static redAbilities s;
	
	public float jumpHeight = 30.0f;
	bool abilitiesActive;
	FirstPersonController fpc;
	
	void Start () {
		s = this;
		this.GetComponent<redAbilities>().enabled = false;
		abilitiesActive = false;
		fpc = GetComponent<FirstPersonController>();
		
	}
	public void activate() {
		fpc.m_JumpSpeed = jumpHeight;
	}
	
	void FixedUpdate() {
	}
}
