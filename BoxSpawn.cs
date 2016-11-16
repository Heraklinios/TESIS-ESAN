using UnityEngine;
using System.Collections;

public class BoxSpawn : MonoBehaviour {

	public GameObject box;
	float timeRespawn = 2;
	float startTimer = 0;


	// Use this for initialization
	void Start () {
		box.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if (box.gameObject.activeInHierarchy == false) {
			startTimer += Time.deltaTime;
			if (startTimer >= timeRespawn) {
				startTimer = 0;
				Respawn ();
			}
		}

	}

	void Respawn(){
		box.gameObject.SetActive (true);
	}
}
