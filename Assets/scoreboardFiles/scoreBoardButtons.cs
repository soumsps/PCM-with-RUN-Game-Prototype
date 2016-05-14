using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreBoardButtons : MonoBehaviour {

	public GameObject restartLastGame;
	public GameObject clickSound;

	public void MainMenuLoad(bool clicked) {
		clickSound.GetComponent<AudioSource> ().Play ();
		if (clicked == true) {
			//Application.LoadLevel ("menu");
			SceneManager.LoadScene("menu");
		} 
	}

		public void RestartLastGameLoad(bool clicked) {
		clickSound.GetComponent<AudioSource> ().Play ();
			if (clicked == true) {
				LevelManager.sessionStatus = "old_session";
				//Application.LoadLevel ("loading");
				SceneManager.LoadScene("loading");

			}
	}
		

	void Update() {
		if (gameDataScript.difficultyLevel == -1 ||gameDataScript.selectedSubject == -1)
			restartLastGame.GetComponent<Button> ().interactable = false;
	}
}
