using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {
	
	public float direction;
	public int speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.right * direction * Time.deltaTime * speed);
		if (this.gameObject.transform.position.x <= -27) {

			transform.position = new Vector2 (40, transform.position.y);
		}

		if (this.gameObject.transform.position.x > 40) {

			transform.position = new Vector2 (-27, transform.position.y);
		}

	}
}
