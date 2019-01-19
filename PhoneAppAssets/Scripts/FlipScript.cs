using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipScript : MonoBehaviour {
	public GameObject objectToFlip; //using left/right variables
	public bool flipping = false;
	public bool isFlipped = false;

	float rotObject;

	// Use this for initialization
	void Start () {
		rotObject = objectToFlip.transform.rotation.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (flipping == true) {
			rotObject = objectToFlip.transform.rotation.eulerAngles.y;
			rotObject = rotObject + 180;
			Vector3 objectOr = new Vector3 (0, rotObject, 0);
			objectToFlip.transform.transform.rotation = Quaternion.Euler(objectOr);

			if (isFlipped == false) {
				isFlipped = true;
			} else {
				isFlipped = false;
			}
			flipping = false;
		}

	}
}
