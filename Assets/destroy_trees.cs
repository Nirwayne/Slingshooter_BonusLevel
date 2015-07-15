using UnityEngine;
using System.Collections;

public class destroy_trees : MonoBehaviour {
	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "tree") {
			Destroy (other.gameObject, 5);
		}
	}
}
