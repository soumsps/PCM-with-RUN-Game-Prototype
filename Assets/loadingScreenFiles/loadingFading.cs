using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadingFading : MonoBehaviour {

	//public float timer = 2f;
	private float fadeSpeed = 2.5f;
	private string levelToLoad= "game";
	private float timeElpsed = 0f;
	private float timeToWait = 1f;
	// Use this for initialization


	void Start () {
		StartCoroutine ("DisplayScene");
	}


	void FixedUpdate ()
	{
		if (timeElpsed >= timeToWait) {

			GetComponent<GUITexture> ().color = Color.Lerp (GetComponent<GUITexture> ().color, Color.black, fadeSpeed * Time.deltaTime);
			if (GetComponent<GUITexture> ().color.a >= 0.9f) {
				// ... set the colour to clear and disable the GUITexture.
				GetComponent<GUITexture> ().color = Color.clear;
				GetComponent<GUITexture> ().enabled = false;
				//Application.LoadLevel (levelToLoad);
				//Debug.Log ("FixedUpdate time :" + Time.deltaTime);

			}
			Debug.Log ("FixedUpdate time :" + Time.deltaTime);

		}

		timeElpsed += Time.deltaTime;
	} 


	IEnumerator DisplayScene() {

		yield return new WaitForSeconds (2);
		//Application.LoadLevel (levelToLoad);
		SceneManager.LoadScene(levelToLoad);



	}


}
