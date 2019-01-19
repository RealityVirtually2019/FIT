using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SpawnModelScript : MonoBehaviour {

	public ImageTargetBehaviour ITB;
	public GameObject Model;

	public SpawnManager SM;

	public bool spawned = false; // make the model spawn only once

	// Use this for initialization
	void Start () {		
	}
	
	// Update is called once per frame
	void Update () {
		if (ITB.CurrentStatus == ImageTargetBehaviour.Status.TRACKED) {
			SM.currITB = ITB;
			if (spawned == false) {
				Instantiate (Model, new Vector3 (0, 0, 3), new Quaternion (0, 0, 0, 0));
				SM.spawnedITB = ITB;
				SM.Model = GameObject.FindGameObjectWithTag("Model");
				spawned = true;
			}

		}
	}
}
