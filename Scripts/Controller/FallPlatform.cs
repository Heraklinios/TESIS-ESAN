using UnityEngine;
using System.Collections;

public class FallPlatform : MonoBehaviour {

	Rigidbody2D rb;
	public float fallDelay;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D obj){
		if (obj.gameObject.CompareTag ("Player")) {
			StartCoroutine (falling ());


		}
	}
		IEnumerator falling(){
			yield return new WaitForSeconds(fallDelay);
			rb.isKinematic = false;
			this.gameObject.GetComponent<BoxCollider2D> ().isTrigger = true;
			yield return new WaitForSeconds(fallDelay + 5);
			this.gameObject.SetActive (false);
			yield return 0;
		}
}
