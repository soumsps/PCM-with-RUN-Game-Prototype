using UnityEngine;
using System.Collections;

public class soundManager_Menu : MonoBehaviour {

	public GameObject menuMusic;
	// Update is called once per frame
	void Update () {

		//------------------MUSIC---------------------------//
		if (gameDataScript.musicStatus == "musicON") {

			menuMusic.GetComponent<AudioSource> ().mute = false;
		} 
		else if (gameDataScript.musicStatus == "musicOFF"){

			menuMusic.GetComponent<AudioSource> ().mute = true;
		}
		//--------------------------------------------------//
	
	}
}
