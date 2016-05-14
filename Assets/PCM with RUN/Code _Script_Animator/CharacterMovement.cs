using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	private Animator animator;            //to get deepak animator controller to this script
	private int lane;					  // integer variable for no. of lanes
	private Vector3 newPosition;		  // deepak's  current positon
	private Vector3 oldPosition;
	// Use this for initialization
	void Start () {
		 lane = -3;							// deepak's initialized lane is -2 : left lane
		 animator = GetComponent<Animator>();
		 oldPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	//	if (Input.GetKeyDown (KeyCode.UpArrow)) {
	//		animator.SetBool ("jumping", true);
	//		Invoke ("stopJumping", 0.1f);
	//	}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			// lane = 3   that means charcter is on right lane 
			if (lane == 3) {	
				lane = -3;
				//float temp_lane = lane / 50;
				for(int i = 0; i < 50; i++)
					newPosition.x = transform.position.x + lane;
				newPosition.y = oldPosition.y;
				newPosition.z = oldPosition.z;
				transform.position = newPosition;
			} 
		}   // leftArrow if()

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			// lane = -3   that means charcter is on left lane 
			if (lane == -3) {
				lane = 3;
				newPosition.x = transform.position.x + lane;
				newPosition.y = oldPosition.y;
				newPosition.z = oldPosition.z;
				transform.position = newPosition;
			}
		}   // RightArrow if()


	} //update

	void stopJumping(){
			animator.SetBool ("jumping", false);
		}

	
	
}
