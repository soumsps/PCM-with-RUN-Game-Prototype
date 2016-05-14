using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class splashScreenScript : MonoBehaviour {

	//public float timer = 2f;
	private float fadeSpeed = 1.1f;
	public string levelToLoad;
	private float timeElpsed = 0f;
	private float timeToWait = 2f;
	// Use this for initialization


	void Start () {
		Screen.SetResolution (1366,768,true);
		StartCoroutine ("DisplayScene");
	}


	void FixedUpdate ()
	{
		if (timeElpsed >= timeToWait) {
			
			GetComponent<GUITexture> ().color = Color.Lerp (GetComponent<GUITexture> ().color, Color.black, fadeSpeed * Time.deltaTime);
			if (GetComponent<GUITexture> ().color.a >= 0.955f) {
				// ... set the colour to clear and disable the GUITexture.
				GetComponent<GUITexture> ().color = Color.clear;
				GetComponent<GUITexture> ().enabled = false;
				//Application.LoadLevel (levelToLoad);
				//Debug.Log ("FixedUpdate time :" + Time.deltaTime);

			}
		//	Debug.Log ("FixedUpdate time :" + Time.deltaTime);

		}

		timeElpsed += Time.deltaTime;
	} 


	IEnumerator DisplayScene() {
		
		yield return new WaitForSeconds (4);
		//Application.LoadLevel (levelToLoad);
		if (levelToLoad == "score") {
			Counter.correct = 0;
			Counter.wrong = 0;
			Counter.greenCount = 0;
			Counter.redCount = 0;
			Counter.yellowCount = 0;
			ques_ansSpawnScript.count = 0;

		}
		SceneManager.LoadScene (levelToLoad);

		 
			
	}


}
