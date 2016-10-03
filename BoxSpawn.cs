using UnityEngine;
using System.Collections;

public class BoxSpawn : MonoBehaviour {

	public GameObject box;
	float timeRespawn = 2;
	float startTimer = 0;


	// Use this for initialization
	void Start () {
		box.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if (box.activeInHierarchy == false) {
			startTimer += Time.deltaTime;
			if (startTimer >= timeRespawn) {
				startTimer = 0;
				Respawn ();
			}
		}

	}

	void Respawn(){
		box.SetActive (true);
	}
}
