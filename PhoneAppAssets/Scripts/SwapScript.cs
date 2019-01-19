using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapScript : MonoBehaviour {
	public GameObject brand;
	public bool left = false;
	public bool right = false;

	float brandPos; // current position in the shirt lineup
	public int itemCount = 4; //how many shirts there are
	public float increments = 1; //how much to move in order to line up shirt
	// Use this for initialization
	void Start () {
		brandPos = brand.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		brandPos = brand.transform.position.x;
		if (left == true && brandPos != Mathf.Abs(0)) {
			brandPos += Mathf.Abs(increments);
			left = false;
		}
		if (right == true && Mathf.Abs(brandPos) != Mathf.Abs(itemCount) - 1) {
			brandPos -= Mathf.Abs(increments);
			right = false;
		}
		brand.transform.position = new Vector3(brandPos,brand.transform.position.y,brand.transform.position.z);

	}
}
