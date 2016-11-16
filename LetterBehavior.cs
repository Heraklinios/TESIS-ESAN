using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class LetterBehavior : MonoBehaviour {

	private Cubos cubo;
	float elapsed = 0;
	bool started = false;
	int randPos;
	public List<Vector2> pos;
	List<char> letters;
	// Use this for initialization
	void Start () {
		
		cubo = new Cubos ();
		pos = GameObject.Find ("Positions").GetComponent<LetterControl> ().posiciones;
		randPos = Random.Range (0,30);
		letters = GameObject.Find ("TextMng").GetComponent<LineRead> ().letters;

	}

	
	// Update is called once per frame

	void Update () {
		
			if (started)
				return;

			elapsed += Time.deltaTime;
			if (elapsed >= 1)
				startMove ();
		
		}


	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.CompareTag ("Player")) {
			

			string s = letters [obj.gameObject.GetComponent<Player> ().lastItemCollected].ToString();
			if(this.gameObject.name.Equals(s)){
				obj.gameObject.GetComponent<Player>().letterCount++;
				obj.gameObject.GetComponent<Player>().lastItemCollected++;

				Destroy (this.gameObject);

				cubo.CollectedCreate (new Vector2(obj.gameObject.GetComponent<Player>().axisX,-2),s);
				obj.gameObject.GetComponent<Player> ().axisX = obj.gameObject.GetComponent<Player> ().axisX + 3;

			}

			}

		}


	

	void startMove(){
			transform.position = Vector2.MoveTowards (transform.position, pos [randPos], 10 * Time.deltaTime);

	}


	void OnDestroy(){
		Instantiate (Resources.Load ("Boom", typeof(GameObject)),transform.position,transform.rotation);
	}
}
