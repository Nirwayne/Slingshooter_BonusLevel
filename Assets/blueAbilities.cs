using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class blueAbilities : MonoBehaviour {
	public static blueAbilities s;

	public float jumpHeight = 30.0f;
	public float walkSpeed = 10;
	public float runSpeed = 30;
	private float oldWalkSpeed = 5;
	private float oldRunSpeed = 10;
	bool gotAbilities;
	bool activateAbilieties;
	FirstPersonController fpc;

	void Start () {
		s = this;
		gotAbilities = false;
		activateAbilieties = false;
		fpc = GetComponent<FirstPersonController>();

	}
	public void activateBlue() {
		fpc.m_JumpSpeed = jumpHeight;
	}
	public void activateRed() {

		gotAbilities = true;
	}

	void FixedUpdate() {
		if (gotAbilities) {
			if (Input.GetKeyDown("f") && activateAbilieties){
				activateAbilieties = false;
				fpc.m_RunSpeed = oldRunSpeed;
				fpc.m_WalkSpeed = oldWalkSpeed;
			} else if (Input.GetKeyDown("f")){
				activateAbilieties = true;
				fpc.m_RunSpeed = runSpeed;
				fpc.m_WalkSpeed = walkSpeed;
			}

		}
	}


}
