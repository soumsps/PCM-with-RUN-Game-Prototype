using UnityEngine;
using System.Collections;

public class streetLightMovementScript : MonoBehaviour {

	public float objectSpeed = -0.26f;
	//float optimizedStreetLightSpeed;

	// Update is called once per frame
	void Update () {
		//optimizedStreetLightSpeed = streetLightSpeed * framerateOptimizer.optimizerFactor;
		transform.Translate(0, 0, objectSpeed);


	}
}

