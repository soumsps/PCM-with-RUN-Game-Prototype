using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

    //Material texture offset rate
	public float speed = 0.7f;
	float optimizedSpeed;
	float temp;
	//Offset the material texture at a constant rate
	void Start(){
		//optimizedSpeed = speed * framerateOptimizer.optimizerFactor;
		//temp = framerateOptimizer.AvgFPS/40.0f;
		//temp = 30.0f/40.0f;


	}
     void Update () {
		//Debug.Log ("optimizedSpeed  : " + offset);
		temp = framerateOptimizer.AvgFPS/40.0f;
		if (temp > 0 && temp < 100) {
			//do nothing
		} else {
			temp = 0.875f;
		}
			float offset = Time.time * speed * temp;  
		
			
		//Debug.Log ("optimizedSpeed_temp  : " + temp);
     GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, -offset); 
}
}
