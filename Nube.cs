using UnityEngine;
using System.Collections;

public class Nube : MonoBehaviour {
	GameObject timer;
	// Use this for initialization
	void Start () {
		timer = GameObject.FindGameObjectWithTag ("Timer");
	}
	
	// Update is called once per frame
	void Update () {
		if (timer.activeInHierarchy == false) {

			transform.Translate (Vector2.right * Time.deltaTime * 5f);
	

			if (this.gameObject.transform.position.x > 40) {

				transform.position = new Vector2 (-27, transform.position.y);
			}

		}
	}
	}

