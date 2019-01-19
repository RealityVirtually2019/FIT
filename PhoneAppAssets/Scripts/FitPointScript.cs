using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FitPointScript : MonoBehaviour {

	public GameObject ModelTrigger;

	public Light LR1;
	public Light LY1;
	public Light LR2;
	public Light LY2;

	public Light LR3;
	public Light LY3;
	public Light LR4;
	public Light LY4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider col){
		LR1.enabled = true;
		LY1.enabled = true;
		LR2.enabled = true;
		LY2.enabled = true;
		LR3.enabled = true;
		LY3.enabled = true;
		LR4.enabled = true;
		LY4.enabled = true;
	}

	void OnTriggerExit(Collider col){
		LR1.enabled = false;
		LY1.enabled = false;
		LR2.enabled = false;
		LY2.enabled = false;
		LR3.enabled = false;
		LY3.enabled = false;
		LR4.enabled = false;
		LY4.enabled = false;
	}
}
