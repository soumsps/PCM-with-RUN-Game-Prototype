using UnityEngine;
using System.Collections;

public class coinSpawnScript : MonoBehaviour { 									//this script dynamically generates bonuses objet during gameplay
	public GameObject Negative_Jump_Bonus;
    public GameObject Positive_Jump_Bonus;
	public GameObject Fitness_Bonus;
  
    float timeElapsed = 0;                    //counter for time
	float spawnCycle = 1.0f;                  // time after which next coin should be generated
	public static float optimizedSpawnCycle;				  // this variable will contain value of framerate optizmised spawncycle
    //bool spawnPowerup = true;
	int[] randomGameObject = new int[] {1,2,3,4};                             //this array is for type of objects that whould be generated
	float[] laneObject = new float[] {-1.32f , 1.32f};                      // this array is for no. of lanes that will we having coin dynamically

	// Use this for initialization
	//void Start () {}

	
	// Update is called once per frame
	void Update () {
		optimizedSpawnCycle = spawnCycle * framerateOptimizer.optimizerFactor;
	timeElapsed += Time.deltaTime;                                          
		if(timeElapsed > optimizedSpawnCycle)
	  {                                         															// During each frame update different different bonuses
		GameObject temp;																					// are generated in random order via these conditions
			if(randomGameObject[Random.Range(0,4)] == 1)
	       {
				temp = (GameObject)Instantiate(Positive_Jump_Bonus);
			    Vector3 pos = temp.transform.position;
				temp.transform.position = new Vector3(laneObject[Random.Range(0,2)] , pos.y ,pos.z);
	       }
			else if(randomGameObject[Random.Range(0,4)] == 2 || randomGameObject[Random.Range(0,4)] == 4)
		   {
				temp = (GameObject)Instantiate(Negative_Jump_Bonus);
			    Vector3 pos = temp.transform.position;
				temp.transform.position = new Vector3(laneObject[Random.Range(0,2)] , pos.y ,pos.z);
		   }
			else if(randomGameObject[Random.Range(0,4)] == 3)
			{
				temp = (GameObject)Instantiate(Fitness_Bonus);
				Vector3 pos = temp.transform.position;
				temp.transform.position = new Vector3(laneObject[Random.Range(0,2)] , pos.y ,pos.z);
			}
		
   timeElapsed = 0;
  }
 }
}
