using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menuButtonManagerScript : MonoBehaviour {

	public GameObject mainMenuButton_Medium;
	public GameObject mainMenuButton_Hard;
	public GameObject medium_text_colour;
	public GameObject hard_text_colour;



	void Update () {
		
		//-----------------------Medium level Buttons status-----------------------------------//

		if (gameDataScript.mediumLock == "locked") {															//Main menu medium level button status
			mainMenuButton_Medium.GetComponent<Button> ().interactable = false;
			medium_text_colour.GetComponent<Text> ().color = Color.gray;
		} else {
			mainMenuButton_Medium.GetComponent<Button> ().interactable = true;
			medium_text_colour.GetComponent<Text> ().color = Color.white;
		}
		//------------------------------------------------------------------------------------//


		//-----------------------Hard level Buttons status-----------------------------------//

		if (gameDataScript.hardLock == "locked") {															//Main menu hard level button status
			mainMenuButton_Hard.GetComponent<Button> ().interactable = false;
			hard_text_colour.GetComponent<Text> ().color = Color.gray;
		} else {
			mainMenuButton_Hard.GetComponent<Button> ().interactable = true;
			hard_text_colour.GetComponent<Text> ().color = Color.white;
		}
		//------------------------------------------------------------------------------------//
	}
	

}
