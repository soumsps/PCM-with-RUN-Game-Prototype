using UnityEngine;
using System.Collections;

public class cloudSystem : MonoBehaviour {

	public float CloudsSpeed;

	void  Update (){
		transform.Rotate(0,Time.deltaTime*CloudsSpeed ,0);                           // rotate 90 degrees around the object's local Y axis:
	}
}