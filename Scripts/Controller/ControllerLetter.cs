using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ControllerLetter : MonoBehaviour {
	private Cubos cubo;
	public List<char> letter;
	//public GameObject cube;
	public GameObject[] cubosGenerados;
	public Vector2[] pos = new Vector2[20];
	int index = 0;
	public int siz;
	//float delay = 1;
	// Use this for initialization
	void Start () {
		cubo = new Cubos();

		pos = GameObject.Find ("Positions").GetComponent<LetterControl> ().posiciones;
		letter = GameObject.Find ("TextMng").GetComponent<LineRead> ().letters;
		siz = GameObject.Find ("TextMng").GetComponent<LineRead> ().totalC;
		while (index < siz) {
			cubo.Create (new Vector2(index - 2,3),letter[index]);
			index++;

		}
		cubosGenerados = GameObject.FindGameObjectsWithTag ("Letter");
	}

	// Update is called once per frame
	void Update () {
		
		StartCoroutine (startMove ());
	}


		//StartCoroutine (startCreation ());
		//while (index < siz) {
		//	cubo.Create (cube,pos[Random.Range(0,pos.Length-1)],letter[index]);
			//Generate ();
		//	index++;

		

		

	
	IEnumerator startMove(){
		yield return new WaitForSeconds(1);
		for(int i = 0; i < siz; i++){
			cubo.Move (cubosGenerados [i], pos [i]);
		}

}
	
	
}
	

