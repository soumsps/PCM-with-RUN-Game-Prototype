using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scorboardDataScript : MonoBehaviour {

	// congratulation screen
	public Transform congrats;
	public GameObject clickSound;

	// ##################  LAST GAME RESULT  ################## //
	// gameobject variable for values field
	public GameObject correctAnswerValue;
	public GameObject positiveBonusValue;
	public GameObject negativeBonusValue;
	public GameObject superBonusValue;

	// gameobject variable for points field  
	public GameObject correctAnswerPoints;
	public GameObject positiveBonusPoints;
	public GameObject negativeBonusPoints;
	public GameObject superBonusPoints;

	// gameobject variable for Totalpoints field
	public GameObject totalPointsPoints;
	public GameObject lastPlayed;
	// ######################################################## //



	// ##################  OVERALL PAST RESULT  ############### //
	public GameObject easy_physicsScore;
	public GameObject easy_chemistryScore;
	public GameObject easy_mathsScore;
	public GameObject easy_totalPoints;

	public GameObject medium_physicsScore;
	public GameObject medium_chemistryScore;
	public GameObject medium_mathsScore;
	public GameObject medium_totalPoints;

	public GameObject hard_physicsScore;
	public GameObject hard_chemistryScore;
	public GameObject hard_mathsScore;
	public GameObject hard_totalPoints;
	// ######################################################## //

	int cav = 0;
	int pbv = 0;
	int nbv = 0;
	int sbv = 0;
	int tp = 0;
	int easy_cutoff = 200;      // 40% of 500(assumed total markes of one subject)
	int medium_cutoff = 225;	// 45% of 500
	int hard_cutoff = 250;		// 50% of 500
	int pcm_et_cutoff = 750;		// 50% of 1500(total of three subject)
	int pcm_mt_cutoff = 825;     // 55% of 1500
	int pcm_ht_cutoff = 900;		// 60% of 1500

	int ep=0;		int ec=0;		int em=0;		int etp =0;	// easy subject variables
	int mp=0;		int mc=0;		int mm=0;		int mtp =0;	// medium subject variables
	int hp=0;		int hc=0;		int hm=0;		int htp =0;	// hard subject variables

	string pass = " (Q)";
	string fail = " (NQ)";
	string ytp = "Yet To Play";
	string lck = "Locked";
	public static bool mediumLock = true;
	public static bool hardLock = true;



	// Use this for initialization
	void Start () {
		
		//-------------LAST GAME DATAVALUES------------------//
		cav = gameDataScript.correctAnswerValue;
		pbv = gameDataScript.positiveBonusValue;
		nbv = gameDataScript.negativeBonusValue;
		sbv = gameDataScript.superBonusValue;

		congrats.gameObject.SetActive (false);

		//Debug.Log (cav);
		//Debug.Log (pbv);

		correctAnswerValue.GetComponent<Text> ().text = cav.ToString();
		positiveBonusValue.GetComponent<Text> ().text = pbv.ToString();
		negativeBonusValue.GetComponent<Text> ().text = nbv.ToString();
		superBonusValue.GetComponent<Text> ().text = sbv.ToString();

		correctAnswerPoints.GetComponent<Text> ().text = (cav * 100).ToString();
		positiveBonusPoints.GetComponent<Text> ().text = (pbv * 5).ToString();
		negativeBonusPoints.GetComponent<Text> ().text = (nbv * (-5)).ToString();
		superBonusPoints.GetComponent<Text> ().text = (sbv * 10).ToString();

		tp = (cav * 100) + (pbv * 5) + (nbv * (-5)) + (sbv * 10); 
		PlayerPrefs.SetInt ("totalPoints", tp);
		//totalPointsPoints.GetComponent<Text> ().text = gameDataScript.totalPoints.ToString();
		//----------------------------------------------------//


		//#############################################################################################################################//

		if (gameDataScript.difficultyLevel == 0 && LevelManager.sessionStatus == "old_session")												//condition for data in easy level
			switch (gameDataScript.selectedSubject) {
			case 0: 
		//	if (tp > gameDataScript.easy_physicsScore)
				PlayerPrefs.SetInt ("easy_physicsScore", tp);
				//lastPlay = "Easy >> Physics";
				PlayerPrefs.SetString("lastLevelPlayed" ,"Easy >> Physics");
				//gameDataScript.easy_physicsScore = gameDataScript.totalPoints;
			break;

		case 1:
		//	if (tp > gameDataScript.easy_chemistryScore)
				PlayerPrefs.SetInt ("easy_chemistryScore", tp);
				//lastPlay = "Easy >> Chemistry";
				PlayerPrefs.SetString("lastLevelPlayed" ,"Easy >> Chemistry");
				//gameDataScript.easy_chemistryScore = gameDataScript.totalPoints;
			break;

		case 2:
		//	if (tp > gameDataScript.easy_mathsScore)
				PlayerPrefs.SetInt ("easy_mathsScore", tp);
				//lastPlay = "Easy >> Mathematics";
				PlayerPrefs.SetString("lastLevelPlayed" ,"Easy >> Mathematics");
				//gameDataScript.easy_mathsScore = gameDataScript.totalPoints;
			break;
		}

		//----------------------------------------------------------------------//

		else if (gameDataScript.difficultyLevel == 1 && LevelManager.sessionStatus == "old_session")												//condition for data in easy level
			switch (gameDataScript.selectedSubject) {
		case 0:
		//	if (tp > gameDataScript.medium_physicsScore)
				PlayerPrefs.SetInt ("medium_physicsScore", tp);
				//lastPlay = "Medium >> Physics";
				PlayerPrefs.SetString("lastLevelPlayed" ,"Medium >> Physics");
				//gameDataScript.medium_physicsScore = gameDataScript.totalPoints;
			break;

		case 1:
		//	if (tp > gameDataScript.medium_chemistryScore)
				PlayerPrefs.SetInt ("medium_chemistryScore", tp);
				//lastPlay = "Medium >> Chemistry";
				PlayerPrefs.SetString("lastLevelPlayed" ,"Medium >> Chemistry");
				//gameDataScript.medium_chemistryScore = gameDataScript.totalPoints;
			break;

		case 2:
		//	if (tp > gameDataScript.medium_mathsScore)
				PlayerPrefs.SetInt ("medium_mathsScore", tp);
				//lastPlay = "Medium >> Mathematics";
			PlayerPrefs.SetString("lastLevelPlayed" ,"Medium >> Mathematics");
				//gameDataScript.medium_mathsScore = gameDataScript.totalPoints;
			break;
		}

		//-------------------------------------------------------------------------//

		else if (gameDataScript.difficultyLevel == 2 && LevelManager.sessionStatus == "old_session")												//condition for data in easy level
			switch (gameDataScript.selectedSubject) {
		case 0:
		//	if (tp > gameDataScript.hard_physicsScore)
				PlayerPrefs.SetInt ("hard_physicsScore", tp);
				//lastPlay = "Hard >> Physics";
				PlayerPrefs.SetString("lastLevelPlayed" ,"Hard >> Physics");
				//gameDataScript.hard_physicsScore = gameDataScript.totalPoints;
			break;

		case 1:
		//	if (tp > gameDataScript.hard_chemistryScore)
				PlayerPrefs.SetInt ("hard_chemistryScore", tp);
				//lastPlay = "Hard >> Chemistry";
				PlayerPrefs.SetString("lastLevelPlayed" ,"Hard >> Chemistry");
				//gameDataScript.hard_chemistryScore = gameDataScript.totalPoints;
			break;

		case 2:
		//	if (tp > gameDataScript.hard_mathsScore)
				PlayerPrefs.SetInt ("hard_mathsScore", tp);
				//lastPlay = "Hard >> Mathematics";
				PlayerPrefs.SetString("lastLevelPlayed" ,"Hard >> Mathematics");
				//gameDataScript.hard_mathsScore = gameDataScript.totalPoints;
			break;
		}
		//#############################################################################################################################//





	}

	void Update() {
		
		totalPointsPoints.GetComponent<Text> ().text = gameDataScript.totalPoints.ToString();
		lastPlayed.GetComponent<Text> ().text = gameDataScript.lastLevelPlayed;

		//-------------OVERALL PAST RESULT DATAVALUES------------------//
		ep = gameDataScript.easy_physicsScore;
		ec = gameDataScript.easy_chemistryScore;
		em = gameDataScript.easy_mathsScore;
		etp = ep + ec + em;

		mp = gameDataScript.medium_physicsScore;
		mc = gameDataScript.medium_chemistryScore;
		mm = gameDataScript.medium_mathsScore;
		mtp = mp + mc + mm;

		hp = gameDataScript.hard_physicsScore;
		hc = gameDataScript.hard_chemistryScore;
		hm = gameDataScript.hard_mathsScore;
		htp = hp + hc + hm;
		//-------------------------------------------------------------//

		//-------------OVERALL PAST RESULT DATAVALUES-------EASY-----------//
		if (ep == 0) {
			easy_physicsScore.GetComponent<Text> ().text = ytp;
			easy_physicsScore.GetComponent<Text> ().color = Color.green;
		} else if (ep >= easy_cutoff) {
			easy_physicsScore.GetComponent<Text> ().text = ep + pass;
			easy_physicsScore.GetComponent<Text> ().color = Color.white;
		} else {
			easy_physicsScore.GetComponent<Text> ().text = ep + fail;
			easy_physicsScore.GetComponent<Text> ().color = Color.white;
		}


		if (ec == 0) {
			easy_chemistryScore.GetComponent<Text> ().text = ytp;
			easy_chemistryScore.GetComponent<Text> ().color = Color.green;
		} else if (ec >= easy_cutoff) {
			easy_chemistryScore.GetComponent<Text> ().text = ec + pass;
			easy_chemistryScore.GetComponent<Text> ().color = Color.white;
		} else {
			easy_chemistryScore.GetComponent<Text> ().text = ec + fail;
			easy_chemistryScore.GetComponent<Text> ().color = Color.white;
		}


		if (em == 0) {
			easy_mathsScore.GetComponent<Text> ().text = ytp;
			easy_mathsScore.GetComponent<Text> ().color = Color.green;
		} else if (em >= easy_cutoff) {
			easy_mathsScore.GetComponent<Text> ().text = em + pass;
			easy_mathsScore.GetComponent<Text> ().color = Color.white;
		} else {
			easy_mathsScore.GetComponent<Text> ().text = em + fail;
			easy_mathsScore.GetComponent<Text> ().color = Color.white;
		}


		if (etp == 0) {																		//easy total points
			easy_totalPoints.GetComponent<Text> ().text = "Not Played";
			easy_totalPoints.GetComponent<Text> ().color = Color.yellow;
			PlayerPrefs.SetString ("mediumLock", "locked");
			PlayerPrefs.SetString ("hardLock", "locked");
			mediumLock = true;
			hardLock = true;
		} else if (etp >= pcm_et_cutoff && ep >= easy_cutoff && ec >= easy_cutoff && em >= easy_cutoff) {
			easy_totalPoints.GetComponent<Text> ().text = etp + " (P)";
			easy_totalPoints.GetComponent<Text> ().color = Color.green;
			PlayerPrefs.SetString ("mediumLock", "unlocked");
			PlayerPrefs.SetString ("hardLock", "locked");
			mediumLock = false;  //Locking Mechanism for medium level
			hardLock =true;
		} else {
			easy_totalPoints.GetComponent<Text> ().text = etp + " (F)";
			easy_totalPoints.GetComponent<Text> ().color = Color.red;
			PlayerPrefs.SetString ("mediumLock", "locked");
			PlayerPrefs.SetString ("hardLock", "locked");
			mediumLock = true;
			hardLock = true;
		}


		//------------------------MEDIUM----------------------------------------//
		if (mediumLock == true) {
			medium_physicsScore.GetComponent<Text> ().text = lck;
			medium_physicsScore.GetComponent<Text> ().color = Color.red;
			medium_chemistryScore.GetComponent<Text> ().text = lck;
			medium_chemistryScore.GetComponent<Text> ().color = Color.red;
			medium_mathsScore.GetComponent<Text> ().text = lck;
			medium_mathsScore.GetComponent<Text> ().color = Color.red;
			medium_totalPoints.GetComponent<Text> ().text = "Not Played";
			medium_totalPoints.GetComponent<Text> ().color = Color.yellow;
		} else {
			if (mp == 0) {
				medium_physicsScore.GetComponent<Text> ().text = ytp;
				medium_physicsScore.GetComponent<Text> ().color = Color.green;
			} else if (mp >= medium_cutoff) {
				medium_physicsScore.GetComponent<Text> ().text = mp + pass;
				medium_physicsScore.GetComponent<Text> ().color = Color.white;
			} else {
				medium_physicsScore.GetComponent<Text> ().text = mp + fail;
				medium_physicsScore.GetComponent<Text> ().color = Color.white;
			}


			if (mc == 0) {
				medium_chemistryScore.GetComponent<Text> ().text = ytp;
				medium_chemistryScore.GetComponent<Text> ().color = Color.green;
			} else if (mc >= medium_cutoff) {
				medium_chemistryScore.GetComponent<Text> ().text = mc + pass;
				medium_chemistryScore.GetComponent<Text> ().color = Color.white;
			} else {
				medium_chemistryScore.GetComponent<Text> ().text = mc + fail;
				medium_chemistryScore.GetComponent<Text> ().color = Color.white;
			}


			if (mm == 0) {
				medium_mathsScore.GetComponent<Text> ().text = ytp;
				medium_mathsScore.GetComponent<Text> ().color = Color.green;
			} else if (mm >= medium_cutoff) {
				medium_mathsScore.GetComponent<Text> ().text = mm + pass;
				medium_mathsScore.GetComponent<Text> ().color = Color.white;
			} else {
				medium_mathsScore.GetComponent<Text> ().text = mm + fail;
				medium_mathsScore.GetComponent<Text> ().color = Color.white;
			}


			if (mtp == 0) {
				medium_totalPoints.GetComponent<Text> ().text = "Not Played";
				medium_totalPoints.GetComponent<Text> ().color = Color.yellow;
				PlayerPrefs.SetString ("hardLock", "locked");
				hardLock = true;
			} else if (mtp >= pcm_mt_cutoff && mp >= medium_cutoff && mc >= medium_cutoff && mm >= medium_cutoff) {
				medium_totalPoints.GetComponent<Text> ().text = mtp + " (P)";
				medium_totalPoints.GetComponent<Text> ().color = Color.green;
				PlayerPrefs.SetString ("hardLock", "unlocked");
				hardLock = false;
			} else {
				medium_totalPoints.GetComponent<Text> ().text = mtp + " (F)";
				medium_totalPoints.GetComponent<Text> ().color = Color.red;
				PlayerPrefs.SetString ("hardLock", "locked");
				hardLock = true;
			}
		}
		//------------------------------HARD-----------------------------------------//
		if (hardLock == true) {
			hard_physicsScore.GetComponent<Text> ().text = lck;
			hard_physicsScore.GetComponent<Text> ().color = Color.red;
			hard_chemistryScore.GetComponent<Text> ().text = lck;
			hard_chemistryScore.GetComponent<Text> ().color = Color.red;
			hard_mathsScore.GetComponent<Text> ().text = lck;
			hard_mathsScore.GetComponent<Text> ().color = Color.red;
			hard_totalPoints.GetComponent<Text> ().text = "Not Played";
			hard_totalPoints.GetComponent<Text> ().color = Color.yellow;
		} else {
			if (hp == 0) {
				hard_physicsScore.GetComponent<Text> ().text = ytp;
				hard_physicsScore.GetComponent<Text> ().color = Color.green;
			} else if (hp >= hard_cutoff) {
				hard_physicsScore.GetComponent<Text> ().text = hp + pass;
				hard_physicsScore.GetComponent<Text> ().color = Color.white;
			} else {
				hard_physicsScore.GetComponent<Text> ().text = hp + fail;
				hard_physicsScore.GetComponent<Text> ().color = Color.white;
			}


			if (hc == 0) {
				hard_chemistryScore.GetComponent<Text> ().text = ytp;
				hard_chemistryScore.GetComponent<Text> ().color = Color.green;
			} else if (hc >= hard_cutoff) {
				hard_chemistryScore.GetComponent<Text> ().text = hc + pass;
				hard_chemistryScore.GetComponent<Text> ().color = Color.white;
			} else {
				hard_chemistryScore.GetComponent<Text> ().text = hc + fail;
				hard_chemistryScore.GetComponent<Text> ().color = Color.white;
			}


			if (hm == 0) {
				hard_mathsScore.GetComponent<Text> ().text = ytp;
				hard_mathsScore.GetComponent<Text> ().color = Color.green;
			} else if (hm >= hard_cutoff) {
				hard_mathsScore.GetComponent<Text> ().text = hm + pass;
				hard_mathsScore.GetComponent<Text> ().color = Color.white;
			} else {
				hard_mathsScore.GetComponent<Text> ().text = hm + fail;
				hard_mathsScore.GetComponent<Text> ().color = Color.white;
			}

		
			if (htp == 0) {
				hard_totalPoints.GetComponent<Text> ().text ="Not Played";
				hard_totalPoints.GetComponent<Text> ().color = Color.yellow;
			}
			else if (htp >= pcm_ht_cutoff && hp >= hard_cutoff && hc >= hard_cutoff && hm >= hard_cutoff) {
				hard_totalPoints.GetComponent<Text> ().text = htp + " (Win)";
				hard_totalPoints.GetComponent<Text> ().color = Color.green;
				if(gameDataScript.countCongrats == 0){
					congrats.gameObject.SetActive (true);												// congratulation screen
					PlayerPrefs.SetInt ("countCongrats", 1);
				}

			} else {
				hard_totalPoints.GetComponent<Text> ().text = htp + " (Fail)";
				hard_totalPoints.GetComponent<Text> ().color = Color.red;
			}
		}
		//-----------------------------------------------------------------------------//
	
	
	}

	public void closeCongratsDialog(){
		clickSound.GetComponent<AudioSource> ().Play ();
		congrats.gameObject.SetActive (false);
	}

	public void resetGameData() {
		clickSound.GetComponent<AudioSource> ().Play ();
		gameDataScript.resetPlayerPrefs ();
	}


}
