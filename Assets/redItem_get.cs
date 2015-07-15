using UnityEngine;
using System.Collections;

public class redItem_get : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			// give other special abilities
			other.GetComponent<blueAbilities>().enabled = true;
			blueAbilities.s.activateRed();
			
			Destroy(this.gameObject);
		}
	}
}
