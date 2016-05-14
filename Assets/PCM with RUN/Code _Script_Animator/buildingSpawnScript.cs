using UnityEngine;
using System.Collections;

public class buildingSpawnScript : MonoBehaviour { 									//this script dynamically generates bonuses objet during gameplay
	public GameObject building_1;
	public GameObject building_2;
	public GameObject building_3;
	public GameObject building_4;
	public GameObject building_5;

	float timeElapsed = 0;                    //counter for time
	float spawnCycle = 3.0f;                  // time after which next coin should be generated
	float optimizedSpawnCycle;

	int[] randomBuildingObject = new int[] {1,2,3};                             //this array is for type of objects that whould be generated
	int[] randomBigBuildingObject = new int[] {1,2};
	float[,] buildingPosition = new float[3,3] {{-12.33f , 3.04f , 62.8f},
												{-21.4f , 3.04f , 67.68f},             // this array is for position x,y,z for new buildings generating dynamically
												{-12.6f , 3.04f , 72.9f}};

	float[,] BigBuildingPosition = new float[4,3] {{-16.6f , 4.15f , 56.5f},
											       {-25.0f , 4.15f , 58.7f},
												   {-30.6f , 4.15f , 69.3f},				// this array is for position x,y,z for new buildings generating dynamically
												   {-25.0f , 4.15f , 75.2f}};
	// Use this for initialization
	//void Start () {}


	// Update is called once per frame
	void Update () {
		optimizedSpawnCycle = spawnCycle * framerateOptimizer.optimizerFactor;
		timeElapsed += Time.deltaTime;                                          
		if(timeElapsed > optimizedSpawnCycle)
		{                                         															// During each frame update different different bonuses
			GameObject temp;  
			int randomBuilding = 0;
			int randomBigBuilding = 0;
			// are generated in random order via these conditions

			for (int i = 0; i < 3; i++) {
				randomBuilding = randomBuildingObject [Random.Range (0, 3)];

				switch (randomBuilding) {

				case 1:		temp = (GameObject)Instantiate (building_1);
							temp.transform.position = new Vector3 (buildingPosition [i, 0], buildingPosition [i, 1], buildingPosition [i, 2]);
							break;

				case 2:		temp = (GameObject)Instantiate (building_2);
					        temp.transform.position = new Vector3 (buildingPosition [i, 0], buildingPosition [i, 1], buildingPosition [i, 2]);
					        break;

				case 3:		temp = (GameObject)Instantiate (building_3);
					        temp.transform.position = new Vector3 (buildingPosition [i, 0], buildingPosition [i, 1], buildingPosition [i, 2]);
					        break;

				}
                  
			}

			for (int i = 0; i < 4; i++) {
				randomBigBuilding = randomBigBuildingObject [Random.Range (0, 2)];

				switch (randomBigBuilding) {

				case 1:		temp = (GameObject)Instantiate (building_4);
					        temp.transform.position = new Vector3 (BigBuildingPosition [i, 0], BigBuildingPosition [i, 1], BigBuildingPosition [i, 2]);
					        break;

				case 2:		temp = (GameObject)Instantiate (building_5);
					        temp.transform.position = new Vector3 (BigBuildingPosition [i, 0], BigBuildingPosition [i, 1], BigBuildingPosition [i, 2]);
					        break;
				}

			}

			timeElapsed = 0;
			// spawnPowerup = !spawnPowerup;
		}
	}
}
