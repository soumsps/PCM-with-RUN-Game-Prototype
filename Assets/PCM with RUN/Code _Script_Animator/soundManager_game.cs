using UnityEngine;
using System.Collections;

public class soundManager_game : MonoBehaviour {

	public GameObject soundfx_seaBackground;
	public GameObject soundfx_greenCoin;
	public GameObject soundfx_redCoin;
	public GameObject soundfx_yelloCoin;
	public GameObject soundfx_footstep;
	public GameObject soundfx_correctAns;
	public GameObject soundfx_wrongAns;

	
	// Update is called once per frame
	void Update () {

		//-----------------SOUND FX-------------------------//
		if (gameDataScript.soundFxStatus == "soundFxON") {

			soundfx_seaBackground.GetComponent<AudioSource> ().mute = false;
			soundfx_greenCoin.GetComponent<AudioSource> ().mute = false;
			soundfx_redCoin.GetComponent<AudioSource> ().mute = false;
			soundfx_yelloCoin.GetComponent<AudioSource> ().mute = false;
			soundfx_footstep.GetComponent<AudioSource> ().mute = false;
			soundfx_correctAns.GetComponent<AudioSource> ().mute = false;
			soundfx_wrongAns.GetComponent<AudioSource> ().mute = false;
		} 
		else if (gameDataScript.soundFxStatus == "soundFxOFF"){

			soundfx_seaBackground.GetComponent<AudioSource> ().mute = true;
			soundfx_greenCoin.GetComponent<AudioSource> ().mute = true;
			soundfx_redCoin.GetComponent<AudioSource> ().mute = true;
			soundfx_yelloCoin.GetComponent<AudioSource> ().mute = true;
			soundfx_footstep.GetComponent<AudioSource> ().mute = true;
			soundfx_correctAns.GetComponent<AudioSource> ().mute = true;
			soundfx_wrongAns.GetComponent<AudioSource> ().mute = true;
		}
		//---------------------------------------------------//
	
	}
}
