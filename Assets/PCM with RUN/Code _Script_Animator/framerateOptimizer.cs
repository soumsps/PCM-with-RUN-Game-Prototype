using UnityEngine;
using System.Collections;

public class framerateOptimizer : MonoBehaviour {
	int target = 35;
	public static float optimizerFactor = 0.0f;           
	float orignalFrameRate = 40.0f;
	float currentFrameRate;
	int qty = 0;
	int qty2 =0;
	public static int count =0;
	public static float AvgFPS = 0.0f;
	float AvgOF = 0.0f;


	void Start () {
		QualitySettings.vSyncCount = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
		++count;
		if (target != Application.targetFrameRate) {                      // setting up maximum framrate
			Application.targetFrameRate = target;
		}
		currentFrameRate = 1.0f / Time.smoothDeltaTime;
		float tempOptimizerFactor = orignalFrameRate / currentFrameRate;                //this value is always greater than 1

		if (count < 500 && pressEnterScript.gameStart_nowTakeAvgOF == true) {
			AverageOF (tempOptimizerFactor);
			optimizerFactor = AvgOF;
		}

		Debug.Log ("count of frames : " + count);


		if (count < 80)															// average of 80 frames to guess the framerate
		    AverageFPS (currentFrameRate);
		else if (AvgFPS > target) {
			AvgFPS = target;
		} else {
			target = (int)AvgFPS;
		}
	}

	void AverageFPS(float newFPS)
	{
		++qty;
		AvgFPS += (newFPS - AvgFPS)/ qty;
		//optimizerFactor = orignalFrameRate / AvgFPS;
	}

	void AverageOF(float newOF)
	{
		++qty2;
		AvgOF += (newOF - AvgOF)/ qty2;
	}


}
