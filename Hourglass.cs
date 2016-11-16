using UnityEngine;
using System.Collections;

public class Hourglass : MonoBehaviour {


	GameObject timer;

	// Use this for initialization
	void Start () {
		timer = GameObject.FindGameObjectWithTag ("Timer");

	}
	
	// Update is called once per frame
	void Update () {
		if(timer.activeInHierarchy == false){
			Destroy (this.gameObject);
		}
	}
}
