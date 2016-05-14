using UnityEngine;
using System.Collections;

public class pressEnterScript : MonoBehaviour {

	public GameObject initialBuildings;
	public GameObject ground;
	public GameObject rightRoadBarrier;
	public GameObject leftRoadBarrier;
	public GameObject rightPavement;
	public GameObject leftPavement;
	public GameObject deepak;
	public GameObject water;
	public GameObject railing;
	public GameObject leftPlaneArea;
	public GameObject skySystem;
	public GameObject initialStreetlight_1;
	public GameObject initialStreetlight_2;
	public GameObject startBanner;
	public GameObject quesBanner;
	public GameObject left_ans;
	public GameObject right_ans;
	public GameObject gameController;
	public GameObject footstepAudio;
	public GameObject riverFx;
	public static bool gameStart_nowTakeAvgOF;

	//public int countMax;  //max countdown number
	//private int countDown;  //current countdown number
	//public GUIText guiTextCountdown;//GUIText reference
	// Use this for initialization
	void Start () {
		MonoBehaviour[] scriptComponentsGameControl = gameObject.GetComponents<MonoBehaviour>();   //get all the script components attached
		//loop through all the scripts and disable them
		gameStart_nowTakeAvgOF =false;
		foreach(MonoBehaviour script in scriptComponentsGameControl) {
			script.enabled = false;
		}

		gameController.GetComponent<pressEnterScript>().enabled = true;
		gameController.GetComponent<framerateOptimizer> ().enabled = true;

		//disable all the scripts attached to the walls, ground. Also disable the animation of character
		initialBuildings.GetComponent<MonoBehaviour>().enabled = false;
		ground.GetComponent<MonoBehaviour>().enabled = false;
		rightRoadBarrier.GetComponent<MonoBehaviour>().enabled = false;
		leftRoadBarrier.GetComponent<MonoBehaviour>().enabled = false;
		rightPavement.GetComponent<MonoBehaviour>().enabled = false;
		leftPavement.GetComponent<MonoBehaviour>().enabled = false;
		deepak.GetComponent<Animator>().enabled = false;
		water.GetComponent<MonoBehaviour>().enabled = false;
		railing.GetComponent<MonoBehaviour>().enabled = false;
		leftPlaneArea.GetComponent<MonoBehaviour>().enabled = false;
		skySystem.GetComponent<MonoBehaviour>().enabled = false;
		initialStreetlight_1.GetComponent<MonoBehaviour>().enabled = false;
		initialStreetlight_2.GetComponent<MonoBehaviour>().enabled = false;
		startBanner.GetComponent<MonoBehaviour>().enabled = false;
		quesBanner.GetComponent<MonoBehaviour>().enabled = false;
		left_ans.GetComponent<MonoBehaviour>().enabled = false;
		right_ans.GetComponent<MonoBehaviour>().enabled = false;
		footstepAudio.GetComponent<AudioSource> ().enabled = false;
		riverFx.GetComponent<AudioSource> ().enabled = false;
		//Call the CountdownFunction
		//StartCoroutine(CountdownFunction());
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)) {
			//enable all the scripts and animation once the count is down
			gameStart_nowTakeAvgOF= true;
			framerateOptimizer.count = 100;
			MonoBehaviour[] scriptComponentsGameControl = gameObject.GetComponents<MonoBehaviour>();   
			foreach(MonoBehaviour script in scriptComponentsGameControl) {
				script.enabled = true;
			}

			initialBuildings.GetComponent<MonoBehaviour>().enabled = true;
			ground.GetComponent<MonoBehaviour>().enabled = true;
			rightRoadBarrier.GetComponent<MonoBehaviour>().enabled = true;
			leftRoadBarrier.GetComponent<MonoBehaviour>().enabled = true;
			rightPavement.GetComponent<MonoBehaviour>().enabled = true;
			leftPavement.GetComponent<MonoBehaviour>().enabled = true;
			deepak.GetComponent<Animator>().enabled = true;
			water.GetComponent<MonoBehaviour>().enabled = true;
			railing.GetComponent<MonoBehaviour>().enabled = true;
			leftPlaneArea.GetComponent<MonoBehaviour>().enabled = true;
			skySystem.GetComponent<MonoBehaviour>().enabled = true;
			initialStreetlight_1.GetComponent<MonoBehaviour>().enabled = true;
			initialStreetlight_2.GetComponent<MonoBehaviour>().enabled = true;
			startBanner.GetComponent<MonoBehaviour>().enabled = true;
			quesBanner.GetComponent<MonoBehaviour>().enabled = true;
			left_ans.GetComponent<MonoBehaviour>().enabled = true;
			right_ans.GetComponent<MonoBehaviour>().enabled = true;
			footstepAudio.GetComponent<AudioSource> ().enabled = true;
			riverFx.GetComponent<AudioSource> ().enabled = true;

			gameController.GetComponent<pressEnterScript>().enabled = false;
		}

	}



/*	IEnumerator CountdownFunction() {
		//start the countdown
		for(countDown = countMax; countDown>-1;countDown--){
			if(countDown!=0){
				//display the number to the screen via the GUIText
				guiTextCountdown.text = countDown.ToString();
				//add a one second delay
				yield return new WaitForSeconds(1);    
			}
			else{
				guiTextCountdown.text = "GO!";
				yield return new WaitForSeconds(1);
			}
		}
		//enable all the scripts and animation once the count is down
		MonoBehaviour[] scriptComponentsGameControl = gameObject.GetComponents<MonoBehaviour>();   
		foreach(MonoBehaviour script in scriptComponentsGameControl) {
			script.enabled = true;
		}

		wall1.GetComponent<GroundControl>().enabled = true;
		wall2.GetComponent<GroundControl>().enabled = true;
		ground.GetComponent<GroundControl>().enabled = true;
		character.GetComponent<Animation>().enabled = true;
		//disable the GUIText once the countdown is done with
		guiTextCountdown.enabled = false;
	}  */
}