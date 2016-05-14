using UnityEngine;
using System.Collections;

public class selfDestroyScript : MonoBehaviour {

	// Use this for initialization
	void OnBecameInvisible() {
		//enabled = false;
		Destroy (gameObject);
	}
}
