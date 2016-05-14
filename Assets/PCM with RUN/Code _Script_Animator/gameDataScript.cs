using UnityEngine;
using System.Collections;

public class gameDataScript : MonoBehaviour {

	public static int difficultyLevel = -1;
	public static int selectedSubject = -1;
	public static string musicStatus;
	public static string soundFxStatus;
	public static string mediumLock;
	public static string hardLock;
	public static string lastLevelPlayed;
	public static int countCongrats;


	//-----------------LAST GAME DATA------------------------------//
	public static int correctAnswerValue;
	public static int wrongAnswerValue;
	public static int positiveBonusValue;
	public static int negativeBonusValue;
	public static int superBonusValue;
	public static int totalPoints;
	//-------------------------------------------------------------//



	//----------------- ALL LEVEL SCORES OF ALL SUBJECT -----------//
	public static int easy_physicsScore;
	public static int easy_chemistryScore;
	public static int easy_mathsScore;
	public static int easy_totalPoints;

	public static int medium_physicsScore;
	public static int medium_chemistryScore;
	public static int medium_mathsScore;
	public static int medium_totalPoints;

	public static int hard_physicsScore;
	public static int hard_chemistryScore;
	public static int hard_mathsScore;
	public static int hard_totalPoints;
	//------------------------------------------------------------//


	void Start () {



		if(!PlayerPrefs.HasKey("musicStatus"))
			PlayerPrefs.SetString ("musicStatus", "musicON");

		if(!PlayerPrefs.HasKey("soundFxStatus"))
			PlayerPrefs.SetString ("soundFxStatus", "soundFxON");

		if(!PlayerPrefs.HasKey("mediumLock"))
			PlayerPrefs.SetString ("mediumLock", "locked");

		if(!PlayerPrefs.HasKey("hardLock"))
			PlayerPrefs.SetString ("hardLock", "locked");

		if(!PlayerPrefs.HasKey("lastLevelPlayed"))
			PlayerPrefs.SetString ("lastLevelPlayed", "");

		if(!PlayerPrefs.HasKey("countCongrats"))
			PlayerPrefs.SetInt ("countCongrats", 0);

		//----------------LAST GAME DATA--------------------------//
		if(!PlayerPrefs.HasKey("correctAnswerValue"))
			PlayerPrefs.SetInt ("correctAnswerValue", 0);

		if(!PlayerPrefs.HasKey("wrongAnswerValue"))
			PlayerPrefs.SetInt ("wrongAnswerValue", 0);

		if(!PlayerPrefs.HasKey("positiveBonusValue"))											//if the key is not created it gets created and initialized with zero
			PlayerPrefs.SetInt ("positiveBonusValue", 0);

		if(!PlayerPrefs.HasKey("negativeBonusValue"))
			PlayerPrefs.SetInt ("negativeBonusValue", 0);

		if(!PlayerPrefs.HasKey("superBonusValue"))
			PlayerPrefs.SetInt ("superBonusValue", 0);

		if(!PlayerPrefs.HasKey("totalPoints"))
			PlayerPrefs.SetInt ("totalPoints", 0);
		// ---------------------------------------------------------//


		//----------------ALL LEVEL SCORES OF ALL SUBJECT----------//
		if(!PlayerPrefs.HasKey("easy_physicsScore"))
			PlayerPrefs.SetInt ("easy_physicsScore", 0);
		
		if(!PlayerPrefs.HasKey("easy_chemistryScore"))
			PlayerPrefs.SetInt ("easy_chemistryScore", 0);
		
		if(!PlayerPrefs.HasKey("easy_mathsScore"))
			PlayerPrefs.SetInt ("easy_mathsScore", 0);

		if(!PlayerPrefs.HasKey("easy_totalPoints"))
			PlayerPrefs.SetInt ("easy_totalPoints", 0);



		if(!PlayerPrefs.HasKey("medium_physicsScore"))
			PlayerPrefs.SetInt ("medium_physicsScore", 0);

		if(!PlayerPrefs.HasKey("medium_chemistryScore"))
			PlayerPrefs.SetInt ("medium_chemistryScore", 0);

		if(!PlayerPrefs.HasKey("medium_mathsScore"))
			PlayerPrefs.SetInt ("medium_mathsScore", 0);

		if(!PlayerPrefs.HasKey("medium_totalPoints"))
			PlayerPrefs.SetInt ("medium_totalPoints", 0);



		if(!PlayerPrefs.HasKey("hard_physicsScore"))
			PlayerPrefs.SetInt ("hard_physicsScore", 0);

		if(!PlayerPrefs.HasKey("hard_chemistryScore"))
			PlayerPrefs.SetInt ("hard_chemistryScore", 0);

		if(!PlayerPrefs.HasKey("hard_mathsScore"))
			PlayerPrefs.SetInt ("hard_mathsScore", 0);

		if(!PlayerPrefs.HasKey("hard_totalPoints"))
			PlayerPrefs.SetInt ("hard_totalPoints", 0);
		//---------------------------------------------------------//

	}
	

	void Update () {

		difficultyLevel = PlayerPrefs.GetInt ("difficultyLevel");
		selectedSubject = PlayerPrefs.GetInt ("selectedSubject");

		musicStatus = PlayerPrefs.GetString ("musicStatus");
		soundFxStatus = PlayerPrefs.GetString ("soundFxStatus");

		mediumLock = PlayerPrefs.GetString ("mediumLock");				// varible that store info about lock on medium level
		hardLock = PlayerPrefs.GetString ("hardLock");					// varible that store info about lock on medium level
		lastLevelPlayed = PlayerPrefs.GetString("lastLevelPlayed");     // this variable stores info about lastly played level

		countCongrats = PlayerPrefs.GetInt ("countCongrats");

		//-----------------LAST GAME DATA--------------------------//
		correctAnswerValue = PlayerPrefs.GetInt ("correctAnswerValue");
		wrongAnswerValue = PlayerPrefs.GetInt ("wrongAnswerValue");
		positiveBonusValue = PlayerPrefs.GetInt ("positiveBonusValue");
		negativeBonusValue = PlayerPrefs.GetInt ("negativeBonusValue");
		superBonusValue = PlayerPrefs.GetInt ("superBonusValue");
		totalPoints = PlayerPrefs.GetInt ("totalPoints");
		//---------------------------------------------------------//


		//-----------------ALL LEVEL SCORES OF ALL SUBJECT----------//
		easy_physicsScore = PlayerPrefs.GetInt ("easy_physicsScore");
		easy_chemistryScore = PlayerPrefs.GetInt ("easy_chemistryScore");
		easy_mathsScore = PlayerPrefs.GetInt ("easy_mathsScore");
		easy_totalPoints = PlayerPrefs.GetInt ("easy_totalPoints");

		medium_physicsScore = PlayerPrefs.GetInt ("medium_physicsScore");
		medium_chemistryScore = PlayerPrefs.GetInt ("medium_chemistryScore");
		medium_mathsScore = PlayerPrefs.GetInt ("medium_mathsScore");
		medium_totalPoints = PlayerPrefs.GetInt ("medium_totalPoints");

		hard_physicsScore = PlayerPrefs.GetInt ("hard_physicsScore");
		hard_chemistryScore = PlayerPrefs.GetInt ("hard_chemistryScore");
		hard_mathsScore = PlayerPrefs.GetInt ("hard_mathsScore");
		hard_totalPoints = PlayerPrefs.GetInt ("hard_totalPoints");
		//---------------------------------------------------------//

		difficultyLevel = PlayerPrefs.GetInt ("difficultyLevel");
		selectedSubject = PlayerPrefs.GetInt ("selectedSubject");

	}											

	public static void resetPlayerPrefs() {
		//difficultyLevel = -1;
		//selectedSubject = -1;
		PlayerPrefs.SetInt ("difficultyLevel", -1);
		PlayerPrefs.SetInt ("selectedSubject", -1);
		PlayerPrefs.SetString ("mediumLock", "locked");
		PlayerPrefs.SetString ("hardLock", "locked");
		PlayerPrefs.SetString ("lastLevelPlayed", "");

		PlayerPrefs.SetInt ("countCongrats", 0);
		//----------------LAST GAME DATA--------------------------//
			PlayerPrefs.SetInt ("correctAnswerValue", 0);
			PlayerPrefs.SetInt ("wrongAnswerValue", 0);
			PlayerPrefs.SetInt ("positiveBonusValue", 0);
			PlayerPrefs.SetInt ("negativeBonusValue", 0);
			PlayerPrefs.SetInt ("superBonusValue", 0);
			PlayerPrefs.SetInt ("totalPoints", 0);
		// ---------------------------------------------------------//


		//----------------RESET LEVEL SCORES OF ALL SUBJECT----------//
			PlayerPrefs.SetInt ("easy_physicsScore", 0);
			PlayerPrefs.SetInt ("easy_chemistryScore", 0);
			PlayerPrefs.SetInt ("easy_mathsScore", 0);
			PlayerPrefs.SetInt ("easy_totalPoints", 0);

			PlayerPrefs.SetInt ("medium_physicsScore", 0);
			PlayerPrefs.SetInt ("medium_chemistryScore", 0);
			PlayerPrefs.SetInt ("medium_mathsScore", 0);
			PlayerPrefs.SetInt ("medium_totalPoints", 0);

			PlayerPrefs.SetInt ("hard_physicsScore", 0);
			PlayerPrefs.SetInt ("hard_chemistryScore", 0);
			PlayerPrefs.SetInt ("hard_mathsScore", 0);
			PlayerPrefs.SetInt ("hard_totalPoints", 0);
		//---------------------------------------------------------//


		/*
		//----------------RESET LEVEL SCORES OF ALL SUBJECT----------//
		PlayerPrefs.SetInt ("easy_physicsScore", 200);
		PlayerPrefs.SetInt ("easy_chemistryScore", 300);
		PlayerPrefs.SetInt ("easy_mathsScore", 300);
		PlayerPrefs.SetInt ("easy_totalPoints", 0);

		PlayerPrefs.SetInt ("medium_physicsScore", 325);
		PlayerPrefs.SetInt ("medium_chemistryScore",225);
		PlayerPrefs.SetInt ("medium_mathsScore", 325);
		PlayerPrefs.SetInt ("medium_totalPoints", 0);

		PlayerPrefs.SetInt ("hard_physicsScore", 390);
		PlayerPrefs.SetInt ("hard_chemistryScore", 350);
		PlayerPrefs.SetInt ("hard_mathsScore", 0);
		PlayerPrefs.SetInt ("hard_totalPoints", 0);
		//---------------------------------------------------------//
		*/
		//PlayerPrefs.Save();
		Debug.Log ("reset Successfull");
	}
}
