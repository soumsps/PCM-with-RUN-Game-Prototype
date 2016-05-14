using UnityEngine;
using System.Collections;

public class coinMovementScript : MonoBehaviour {

	private float objectSpeed = -0.2f;

	// Use this for initialization
		void Start () {
		
	}
	

	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, objectSpeed, 0);
	}
}
