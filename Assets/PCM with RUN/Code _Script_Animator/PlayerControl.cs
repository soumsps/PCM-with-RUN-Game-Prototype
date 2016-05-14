using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	// CharacterController controller;
	public GameObject greenCoin;
	public GameObject redCoin;
	public GameObject yellowCoin;
	public GameObject wrongSound;
	public GameObject correctSound;

		 void OnTriggerEnter(Collider other)
		 {
			  if(other.gameObject.name == "green_coin(Clone)")
			  {
			        Counter.greenCount++;
					greenCoin.GetComponent<AudioSource> ().Play ();
					Destroy(other.gameObject);
			  }
			  else if(other.gameObject.name == "red_coin(Clone)")
			  {
			        Counter.redCount++;
					redCoin.GetComponent<AudioSource> ().Play ();
					Destroy(other.gameObject);
			   } 
			  else if(other.gameObject.name == "yellow_coin(Clone)")
			  {
			        Counter.yellowCount++;
					yellowCoin.GetComponent<AudioSource> ().Play ();
					Destroy(other.gameObject);
			  }
		       
		if (other.gameObject.name == "left_lane") {
			if (ques_ansSpawnScript.left_lane_ans == "true") {
				correctSound.GetComponent<AudioSource> ().Play ();
				Counter.correct++;
				ques_ansSpawnScript.right_lane_ans = "null";
				ques_ansSpawnScript.left_lane_ans = "null";

			} else if (ques_ansSpawnScript.left_lane_ans == "false") {
				wrongSound.GetComponent<AudioSource> ().Play ();
				Counter.wrong++;
				ques_ansSpawnScript.right_lane_ans = "null";
				ques_ansSpawnScript.left_lane_ans = "null";
			} else {
				//do nothing
			}
		}
				
		if(other.gameObject.name == "right_lane"){
				
			if (ques_ansSpawnScript.right_lane_ans == "true") {
				correctSound.GetComponent<AudioSource> ().Play ();
				Counter.correct++;
				ques_ansSpawnScript.right_lane_ans = "null";
				ques_ansSpawnScript.left_lane_ans = "null";
			} else if(ques_ansSpawnScript.right_lane_ans == "false"){
				wrongSound.GetComponent<AudioSource> ().Play ();
				Counter.wrong++;
				ques_ansSpawnScript.right_lane_ans = "null";
				ques_ansSpawnScript.left_lane_ans = "null";
			}  else{
			// do nothing
			}
		}


}
}