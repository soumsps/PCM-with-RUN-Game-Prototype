using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public Transform mainMenu , optionMenu , aboutMenu , helpMenu , exitMenu;
	public Transform easyMenu, mediumMenu, hardMenu, creditsMenu;
	public static string sessionStatus = "new_session";
	public GameObject musicON;
	public GameObject musicOFF;
	public GameObject soundFxON;
	public GameObject soundFxOFF;
	public GameObject clickSound;
	/// <summary>
	/// gameDataScript.selectedSubject   and 
	/// gameDataScript.difficultyLevel    
	/// variable are reffered again and again  they are PlayerPrefs.
	/// </summary>


	//------------------------------------------------------------------------------------//
	public void Physics() {						// for loading levels
		PlayerPrefs.SetInt ("selectedSubject", 0);
		//gameDataScript.selectedSubject = 0;
		Debug.Log ("PlayerPrefs_selectedSubject = " + gameDataScript.selectedSubject);
		sessionStatus = "old_session";
		clickSound.GetComponent<AudioSource>().Play();
		//Application.LoadLevel ("loading");
		SceneManager.LoadScene("loading");
	}

	public void Chemistry() {						// for loading levels
		PlayerPrefs.SetInt ("selectedSubject", 1);
		//gameDataScript.selectedSubject = 1;
		Debug.Log ("PlayerPrefs_selectedSubject = " + gameDataScript.selectedSubject);
		sessionStatus = "old_session";
		clickSound.GetComponent<AudioSource>().Play();
		//Application.LoadLevel ("loading");
		SceneManager.LoadScene("loading");
	}

	public void Mathematics() {						// for loading levels
		PlayerPrefs.SetInt ("selectedSubject", 2);
		//gameDataScript.selectedSubject = 2;
		Debug.Log ("PlayerPrefs_selectedSubject = " + gameDataScript.selectedSubject);
		sessionStatus = "old_session";
		clickSound.GetComponent<AudioSource>().Play();
		//Application.LoadLevel ("loading");
		SceneManager.LoadScene("loading");
	}
	//---------------------------------------------------------------------------------------//


	public void QuitGame() {     								//for quiting from game
		clickSound.GetComponent<AudioSource>().Play();
		Application.Quit ();
	}

	public void ScoreBoardLoad(bool clicked) {					// this fuction is linked with main menu button "Score Board"
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			//Application.LoadLevel ("score");
			SceneManager.LoadScene("score");
		} 
	}

	public void ResetGameData(bool clicked) {					// this fuction is linked with main menu button "Score Board"
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			gameDataScript.resetPlayerPrefs ();
		} 
	}
	//------------------------------------OPTION MENU------------------------//
	public void OptionMenu(bool clicked) {
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			optionToggleCheck ();
			optionMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} else {
			optionMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}

	public void Music(string status) {
		//clickSound.GetComponent<AudioSource>().Play();
		if (status == "musicON") {
			PlayerPrefs.SetString ("musicStatus", status);
			Debug.Log ("music : " + gameDataScript.musicStatus);
		} else if(status == "musicOFF") {
			PlayerPrefs.SetString ("musicStatus", status);
			Debug.Log ("music : " + gameDataScript.musicStatus);
		}
	}

	public void SoundFx(string status) {
		//clickSound.GetComponent<AudioSource>().Play();
		if (status == "soundFxON") {
			PlayerPrefs.SetString ("soundFxStatus", status);
			Debug.Log ("sound : " + gameDataScript.soundFxStatus);
		} else if(status =="soundFxOFF") {
			PlayerPrefs.SetString ("soundFxStatus", status);
			Debug.Log ("sound : " + gameDataScript.soundFxStatus);
		}
	}

	//---------------------------------------------------------------------------//
	public void ExitMenu(bool clicked) {
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			exitMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} else {
			exitMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}

	public void AboutMenu(bool clicked) {
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			aboutMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} else {
			aboutMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}

	public void CreditMenu(bool clicked) {
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			creditsMenu.gameObject.SetActive (clicked);
			aboutMenu.gameObject.SetActive (false);
		} else {
			creditsMenu.gameObject.SetActive (clicked);
			aboutMenu.gameObject.SetActive (true);
		}
	}

	public void HelpMenu(bool clicked) {
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			helpMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
		} else {
			helpMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
		}
	}

	public void EasyMenu(bool clicked) {
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			easyMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
			//gameDataScript.difficultyLevel = 0;							//if Easy difficultyLevel = 0
			PlayerPrefs.SetInt ("difficultyLevel", 0);
			Debug.Log("difficultyLevel = " + gameDataScript.difficultyLevel);
		} else {
			easyMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
			//gameDataScript.difficultyLevel = -1;						//when user click back difficultyLevel is reset to -1 
			Debug.Log("difficultyLevel = " + gameDataScript.difficultyLevel);
		}
	}

	public void MediumMenu(bool clicked) {
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			mediumMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
			PlayerPrefs.SetInt ("difficultyLevel", 1);
			//gameDataScript.difficultyLevel = 1;						//if medium difficultyLevel = 1;
			Debug.Log("difficultyLevel = " + gameDataScript.difficultyLevel);
		} else {
			mediumMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);
			//gameDataScript.difficultyLevel = -1;						//when user click back difficultyLevel is reset to -1 
			Debug.Log("difficultyLevel = " + gameDataScript.difficultyLevel);
		}
	}

	public void HardMenu(bool clicked) {
		clickSound.GetComponent<AudioSource>().Play();
		if (clicked == true) {
			hardMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (false);
			PlayerPrefs.SetInt ("difficultyLevel", 2);
			//gameDataScript.difficultyLevel = 2;						//if Hard difficultyLevel = 2;
			Debug.Log("difficultyLevel = " + gameDataScript.difficultyLevel);
		} else {
			hardMenu.gameObject.SetActive (clicked);
			mainMenu.gameObject.SetActive (true);							
			//gameDataScript.difficultyLevel = -1;										//when user click back difficultyLevel is reset to -1 
			Debug.Log("difficultyLevel = " + gameDataScript.difficultyLevel);
		}
	}

	void optionToggleCheck() {
		if (gameDataScript.musicStatus == "musicON") {
			musicON.GetComponent<Toggle> ().isOn = true;
			musicOFF.GetComponent<Toggle> ().isOn = false;
		} 
		else if (gameDataScript.musicStatus == "musicOFF"){
			musicON.GetComponent<Toggle> ().isOn = false;
			musicOFF.GetComponent<Toggle> ().isOn = true;
		}

		if (gameDataScript.soundFxStatus == "soundFxON") {
			soundFxON.GetComponent<Toggle> ().isOn = true;
			soundFxOFF.GetComponent<Toggle> ().isOn = false;
		} 
		else if (gameDataScript.soundFxStatus == "soundFxOFF"){
			soundFxON.GetComponent<Toggle> ().isOn = false;
			soundFxOFF.GetComponent<Toggle> ().isOn = true;
		}
	}
}
