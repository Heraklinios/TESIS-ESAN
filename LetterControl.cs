using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class LetterControl : MonoBehaviour {

	public List<Vector2> posiciones;
	//public Vector2[] posiciones = new Vector2[20];
	public float speed;
	public float delay = 1;
	public float xp;
	public float yp;

	public int lengthLetra;
	int lengthObj;
	// Use this for initialization

	void Start () {
		posiciones = new List<Vector2> ();
		RandomPos ();

	}

	// Update is called once per frame
	void Update () {


	}
		void RandomPos(){
		for(int i = 0; i < 40; i++){
			xp = Random.Range (-19, 19);
			yp = Random.Range (5, 20);
			posiciones.Add (new Vector2 (xp, yp));

		}
	}






}
