using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour {

	public GameObject platform;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (platform.activeSelf == false) {
			Invoke ("ReSpawn",1);
		}
	}
	void ReSpawn(){
		platform.SetActive (true);
		platform.transform.position = this.gameObject.transform.position;
		platform.GetComponent<FallPlatform> ().GetComponent<Rigidbody2D> ().isKinematic = true;
		platform.GetComponent<BoxCollider2D> ().isTrigger = false;
	}
}

