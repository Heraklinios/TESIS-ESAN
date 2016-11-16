using UnityEngine;
using System.Collections;

public class GroundDetect : MonoBehaviour {

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D obj){
		if(obj.gameObject.CompareTag("Platform")){
			this.gameObject.GetComponentInParent<Player> ().isGrounded = true;
		}

		if(obj.gameObject.CompareTag("F.Platform")){
			this.gameObject.GetComponentInParent<Player> ().isGrounded = true;
		}
	}

	void OnTriggerExit2D(Collider2D obj){
		if(obj.gameObject.CompareTag("Platform")){
			this.gameObject.GetComponentInParent<Player> ().isGrounded = false;
		}
		if(obj.gameObject.CompareTag("F.Platform")){
			this.gameObject.GetComponentInParent<Player> ().isGrounded = false;
		}
	}

}
