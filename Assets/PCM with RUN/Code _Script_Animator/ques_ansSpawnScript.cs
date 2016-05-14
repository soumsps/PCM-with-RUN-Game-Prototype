using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ques_ansSpawnScript : MonoBehaviour {
	
	public GameObject question;
	public GameObject left_ans;
	public GameObject right_ans;
	public static string left_lane_ans = "false";
	public static string right_lane_ans = "false";

	float timeElapsed = 0;                    //counter for time
	float scoreDisplay = 0;
	float spawnCycle = 10.2f;                  // time after which next questions should be generated
	public static float optimizedSpawnCycle = 0.0f;          // this variable will contain value of framerate optizmised spawncycle
	private int ans_select;
	int[] arr = new int[] {1,2,3,4};      //maximum value of this array ==  no. of questions in each set 

	string[,] pattern = new string[1, 3] {{"ques_","cans_","wans_"}};                // predefine file names
	string[,] level = new string[1, 3] {{"easy","medium","hard"}};                   // predefine level names
	string[,] subject = new string[1, 3] {{"physics","chemistry","mathematics"}};               // predefine subject names

	private Texture tex_ques;         							//temporary texture
	private Texture levelComp;
	private Texture tex_left;
	private Texture tex_right;

	private string path;
	private string path_ques;
	private string path_correct_ans;
	private string path_wrong_ans;

	public static int count =0;

	public Renderer rend_ques;	 												
	public Renderer rend_left_ans;
	public Renderer rend_right_ans;




	void Start() {
	//	rend_ques = GetComponent<Renderer>();							//getting Mesh Renderer for question banner.
	//rend_left_ans = GetComponent<Renderer>();						//getting Mesh Renderer for leftLane answer banner.
	//	rend_right_ans = GetComponent<Renderer>();						//getting Mesh Renderer for RightLane answer banner.

		///////////////////////////////////////////////
		for (int t = 0; t < arr.Length; t++ )								 // Knuth shuffle algorithm
		{																	// suffling the array so that questions will be in random order
			int temp = arr[t];												// suffling {1,2,3,4} to get something like {3,2,4,1}
			int r = Random.Range(t, arr.Length);							
			arr[t] = arr[r];
			arr[r] = temp;
		}
		/////////////////////////////////////////////
		path = level[0,gameDataScript.difficultyLevel] + "/" + subject[0,gameDataScript.selectedSubject] + "/";
		Debug.Log ("superDifficultyLevelCheck : " + gameDataScript.difficultyLevel);
		Debug.Log ("superSelectedSubjectCheck : " + gameDataScript.selectedSubject);

		 
	}




	// Update is called once per frame
	void Update () {    

		optimizedSpawnCycle = spawnCycle * framerateOptimizer.optimizerFactor;
		timeElapsed += Time.deltaTime;                                          
		if(timeElapsed > optimizedSpawnCycle && count < 4)														// During each frame update different different questions
		{       													

			Debug.Log ("hello");
			Debug.Log ("count = " + count);
			int currentNumber = arr[count++];
			//Debug.Log (currentNumber);
			//int currentNumber =0;
			// for generating random question
			GameObject temp_ques;																					
				temp_ques = (GameObject)Instantiate(question);
				Vector3 pos_ques = temp_ques.transform.position;
				temp_ques.transform.position = new Vector3(pos_ques.x , pos_ques.y ,pos_ques.z);
				path_ques = path + pattern [0, 0] + currentNumber;								// path for question image to put in banner
				tex_ques = Resources.Load (path_ques) as Texture;

	//		if (tex_ques == null)
	//			Debug.Log ("Load Texture_ques Fail");
	//		else
	//			Debug.Log ("Load texture_ques successful");
			
				rend_ques.sharedMaterial.mainTexture = tex_ques;
	//		Debug.Log (path_ques);
				
			// for generating answer left
			GameObject temp_leftans;
				temp_leftans = (GameObject)Instantiate(left_ans);
				Vector3 pos_leftans = temp_leftans.transform.position;
				temp_leftans.transform.position = new Vector3(pos_leftans.x , pos_leftans.y ,pos_leftans.z);
			    

			// for generating answer right
			GameObject temp_rightans;
				temp_rightans = (GameObject)Instantiate(right_ans);
				Vector3 pos_rightans = temp_rightans.transform.position;
				temp_rightans.transform.position = new Vector3(pos_rightans.x , pos_rightans.y ,pos_rightans.z);


			ans_select = Random.Range (1, 3);                                             //Random.Range(min[inclusive] , max[exclusive])
			path_correct_ans = path + pattern [0, 1] + currentNumber;									//path for correct answer
			path_wrong_ans = path + pattern [0, 2] + currentNumber;										//path for wrong answer

		//	Debug.Log (path_correct_ans);
		//	Debug.Log (path_wrong_ans);
		//	Debug.Log ("answer_select : " + ans_select);
			if (ans_select == 1) {
				tex_left = Resources.Load (path_correct_ans) as Texture;						//when ans_select = 1
				rend_left_ans.sharedMaterial.mainTexture = tex_left;                            //then left lane will contain correct answer
				left_lane_ans = "true";															//that is left_lane_ans = true

				tex_right = Resources.Load (path_wrong_ans) as Texture;							//and right lane will contain wrong answer
				rend_right_ans.sharedMaterial.mainTexture = tex_right;
				right_lane_ans = "false";															//that is right_lane_ans = false

			} else {
				tex_left = Resources.Load (path_wrong_ans) as Texture;							//if ans_select !=1  then  leftlane banner will contain wrong answer
				rend_left_ans.sharedMaterial.mainTexture = tex_left;							// and rightlane will contain correct answer
				left_lane_ans = "false";

				tex_right = Resources.Load (path_correct_ans) as Texture;
				rend_right_ans.sharedMaterial.mainTexture = tex_right;
				right_lane_ans = "true";
			}

			//timeElapsed -= spawnCycle;
			timeElapsed = 0;
		//	finishtimer = 0;
		}
			

		if(timeElapsed > optimizedSpawnCycle - (1 * framerateOptimizer.optimizerFactor)  && count == 4)														
		{ 
			GameObject levelComplete;																					
			levelComplete = (GameObject)Instantiate(question);
			Vector3 pos_ques = levelComplete.transform.position;
			levelComplete.transform.position = new Vector3(pos_ques.x , pos_ques.y ,pos_ques.z);
			//path_ques = path + pattern [0, 0] + currentNumber;								// path for question image to put in banner
			levelComp = Resources.Load ("levelComplete") as Texture;
			rend_ques.sharedMaterial.mainTexture = levelComp;

					if (tex_ques == null)
						Debug.Log ("Load levelComplete Fail");
					else
						Debug.Log ("Load levelComplete successful");
		//	scoreDisplay = 0;
		//	scoreDisplay = timeElapsed;
			timeElapsed = 0;
			scoreDisplay = 1;
		}

		//scoreDisplay += Time.deltaTime;
		if (timeElapsed > optimizedSpawnCycle - (6 * framerateOptimizer.optimizerFactor) && scoreDisplay == 1) {
			//Application.LoadLevel ("scoreload");
			SceneManager.LoadScene("scoreload");
		
		}
			
	}
		
}
