using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SpawnManager : MonoBehaviour {

	public GameObject Model;
	public ImageTargetBehaviour spawnedITB;

	public ImageTargetBehaviour currITB;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (currITB.TrackableName != spawnedITB.TrackableName) {
			SpawnModelScript SMS = Model.GetComponent("SpawnModelScript") as SpawnModelScript;
			SMS.spawned = false;
			Destroy(Model);
		}	
	}
}
