using UnityEngine;
using System.Collections;

public class streetLightSpawnScript : MonoBehaviour { 
																			//this script dynamically generates bonuses objet during gameplay
	public GameObject streetLight;


	float timeElapsed = 0;                    //counter for time
	float spawnCycle = 2.86f;                  // time after which next new set of street light should be generated
	float optimizedSpawnCycle;


	// Update is called once per frame
	void Update () {
		optimizedSpawnCycle = spawnCycle * framerateOptimizer.optimizerFactor;
		timeElapsed += Time.deltaTime;                                          
		if(timeElapsed > optimizedSpawnCycle)
		{                                         							// During each frame update different different bonuses
			GameObject temp;												// are generated in random order via these conditions

				temp = (GameObject)Instantiate(streetLight);
				//Vector3 pos = temp.transform.position;
			    temp.transform.position = new Vector3(-2.035f , 4.3367f , 36.37f);
				timeElapsed = 0;

		}
	}
}
