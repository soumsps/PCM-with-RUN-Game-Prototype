using UnityEngine;
using System.Collections;

public class soundManager_score : MonoBehaviour {

	public GameObject scoreboardMusic;
	
	// Update is called once per frame
	void Update () {

		//------------------MUSIC---------------------------//
		if (gameDataScript.musicStatus == "musicON") {

			scoreboardMusic.GetComponent<AudioSource> ().mute = false;
		} 
		else if (gameDataScript.musicStatus == "musicOFF"){

			scoreboardMusic.GetComponent<AudioSource> ().mute = true;
		}
		//--------------------------------------------------//
	
	}
}
