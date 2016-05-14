using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour {

	public static int greenCount = 0;      // +ve bonus coin   
	public static int redCount = 0;        // -ve bonus coin
	public static int yellowCount = 0;     // super bonus coin
	public static int correct = 0;
	public static int wrong = 0;
	public Texture greenCoin;
	//public GUIStyle myGreenCoin;
	public Texture redCoin;
	//public GUIStyle myRedCoin;
	public Texture yellowCoin;
	public GUIStyle myCoinStyle;
	public GUIStyle mystyleCorrect;
	public GUIStyle mystyleWrong;
	public GUIStyle mystyleTotalPoint;
	int totalPoint;




	void OnGUI()
	{
		GUI.Box (new Rect (30, 20, 30, 30), greenCoin, myCoinStyle);
		string greenCoinText = "x " + greenCount;
		GUI.Box (new Rect (65, 20, 50, 30), greenCoinText, myCoinStyle);


		GUI.Box (new Rect (30, 60, 30, 30), redCoin,myCoinStyle );
		string redCoinText = "x " + redCount;
		GUI.Box (new Rect (65, 60, 50, 30), redCoinText, myCoinStyle);


		GUI.Box (new Rect (30, 100, 30, 30), yellowCoin, myCoinStyle );
		string yellowCoinText = "x " + yellowCount;
		GUI.Box (new Rect (65, 100, 50, 30), yellowCoinText , myCoinStyle);


		//string correctcount = "Correct : " + correct;
		//GUI.Box (new Rect (483, 20, 100, 30), correctcount, mystyleCorrect);


		//string wrongcount = "Wrong : " + wrong;
		//GUI.Box (new Rect (783, 20, 100, 30), wrongcount, mystyleWrong);

		//totalPoint = (correct * 100) + (greenCount * 5) + (redCount * (-5)) + (yellowCount * 10); 
		//string totalpoint = "Total Points : " + totalPoint;
		//GUI.Box (new Rect (983, 20, 180, 30), totalpoint, mystyleTotalPoint);

		string correctcount = "Correct : " + correct;
		GUI.Box (new Rect (1150, 20, 170, 30), correctcount, mystyleCorrect);


		string wrongcount = "Wrong : " + wrong;
		GUI.Box (new Rect (1150, 60, 170, 30), wrongcount, mystyleWrong);

		totalPoint = (correct * 100) + (greenCount * 5) + (redCount * (-5)) + (yellowCount * 10); 
		string totalpoint = "Total Points : " + totalPoint;
		GUI.Box (new Rect (1150, 100, 170, 30), totalpoint, mystyleTotalPoint);


		/*


		string frameRate = "Frame Rate : " + (int)(1.0f / Time.smoothDeltaTime );
		GUI.Box(new Rect(Screen.width - 1330, 170, 200, 20), frameRate);                                // frame rate display	

		string optimizerFact = "OptimizerFact : " + framerateOptimizer.optimizerFactor;
		GUI.Box(new Rect(Screen.width - 1330, 200, 200, 20), optimizerFact);    

		string optimizerFact1 = "OptimizeQuesSpawn : " + ques_ansSpawnScript.optimizedSpawnCycle;
		GUI.Box(new Rect(Screen.width - 1330, 220, 200, 20), optimizerFact1); 

		string optimizerFact2 = "OptimizeCoinSpawn : " + coinSpawnScript.optimizedSpawnCycle;
		GUI.Box(new Rect(Screen.width - 1330, 240, 200, 20), optimizerFact2); 

		string optimizerFact3 = "AverageFps : " + framerateOptimizer.AvgFPS;
		GUI.Box(new Rect(Screen.width - 1330, 260, 200, 20), optimizerFact3); 

		//------------------------------------------//
		string tp = "totalPoints : " + gameDataScript.totalPoints;
		GUI.Box (new Rect (Screen.width - 250, 20, 200, 20), tp);

		string dl = "difficultyLevel : " + gameDataScript.difficultyLevel;
		GUI.Box (new Rect (Screen.width - 250, 40, 200, 20), dl);

		string sub = "subjectSelected : " + gameDataScript.selectedSubject;
		GUI.Box (new Rect (Screen.width - 250, 60, 200, 20), sub);

		string cor = "correct : " + gameDataScript.correctAnswerValue;
		GUI.Box (new Rect (Screen.width - 250, 80, 200, 20), cor);

		string wor = "wrong : " + gameDataScript.wrongAnswerValue;
		GUI.Box (new Rect (Screen.width - 250, 100, 200, 20), wor);

		string gre = "positive : " + gameDataScript.positiveBonusValue;
		GUI.Box (new Rect (Screen.width - 250, 120, 200, 20), gre);

		string red = "negative : " + gameDataScript.negativeBonusValue;
		GUI.Box (new Rect (Screen.width - 250, 140, 200, 20), red);

		string yel = "super : " + gameDataScript.superBonusValue;
		GUI.Box (new Rect (Screen.width - 250, 160, 200, 20), yel);

		string ep= "easyPhy : " + gameDataScript.easy_physicsScore;
		GUI.Box (new Rect (Screen.width - 250, 180, 200, 20), ep);

		string ec = "easyChem : " + gameDataScript.easy_chemistryScore;
		GUI.Box (new Rect (Screen.width - 250, 200, 200, 20), ec);

		string em= "easyMaths : " + gameDataScript.easy_mathsScore;
		GUI.Box (new Rect (Screen.width - 250, 220, 200, 20), em);

		string mp= "mediumPhy : " + gameDataScript.medium_physicsScore;
		GUI.Box (new Rect (Screen.width - 250, 240, 200, 20), mp);

		string mc = "mediumChem : " + gameDataScript.medium_chemistryScore;
		GUI.Box (new Rect (Screen.width - 250, 260, 200, 20), mc);

		string mm= "mediumMaths : " + gameDataScript.medium_mathsScore;
		GUI.Box (new Rect (Screen.width - 250, 280, 200, 20), mm);

		string hp= "hardPhy : " + gameDataScript.hard_physicsScore;
		GUI.Box (new Rect (Screen.width - 250, 300, 200, 20), hp);

		string hc = "hardChem : " + gameDataScript.hard_chemistryScore;
		GUI.Box (new Rect (Screen.width - 250, 320, 200, 20), hc);

		string hm= "hardMaths : " + gameDataScript.hard_mathsScore;
		GUI.Box (new Rect (Screen.width - 250, 340, 200, 20), hm);

		string music = "musicStatus : " + gameDataScript.musicStatus;
		GUI.Box (new Rect (Screen.width - 250, 360, 200, 20), music);

		string soundFx = "soundStatus : " + gameDataScript.soundFxStatus;
		GUI.Box (new Rect (Screen.width - 250, 380, 200, 20), soundFx);
		//------------------------------------------//

*/
    }

	void Update() {
		//gameDataScript.correctAnswerValue = correct;
		//gameDataScript.wrongAnswerValue = wrong;
		//gameDataScript.positiveBonusValue = greenCount;
		//gameDataScript.negativeBonusValue = redCount;
		//gameDataScript.superBonusValue = yellowCount;

		PlayerPrefs.SetInt ("correctAnswerValue", correct);
		PlayerPrefs.SetInt ("wrongAnswerValue", wrong);
		PlayerPrefs.SetInt ("positiveBonusValue", greenCount);
		PlayerPrefs.SetInt ("negativeBonusValue", redCount);
		PlayerPrefs.SetInt ("superBonusValue", yellowCount);
	}
}