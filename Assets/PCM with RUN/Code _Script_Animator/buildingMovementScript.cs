using UnityEngine;
using System.Collections;

public class buildingMovementScript : MonoBehaviour {

	public float objectSpeed = -0.2f;
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, objectSpeed);
	}
}

