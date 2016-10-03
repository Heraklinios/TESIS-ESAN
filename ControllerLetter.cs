using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ControllerLetter : MonoBehaviour {
	private Cubos cubo;
	public List<char> letter;
	public GameObject cube;
	public Vector2[] pos = new Vector2[20];
	int index = 0;
	public int siz;
	//float delay = 1;
	// Use this for initialization
	void Start () {
		cubo = new Cubos(cube);


		pos = GameObject.Find ("Positions").GetComponent<LetterControl> ().posiciones;
		letter = GameObject.Find ("TextMng").GetComponent<LineRead> ().letters;

		//transform.position = new Vector2 (-1, 3);


	}

	// Update is called once per frame
	void Update () {
		siz = letter.Capacity - 1;
		StartCoroutine (startCreation ());
		//while (index < siz) {
		//	cubo.Create (cube,pos[Random.Range(0,pos.Length-1)],letter[index]);
			//Generate ();
		//	index++;

		}

		//StartCoroutine (startPos ());

	//void Generate(){
	//	cubo.Create (cube,pos[Random.Range(0,pos.Length-1)]);
		//cubo.SetDestination (pos [Random.Range (0, pos.Length - 1)]);
	//}
	IEnumerator startCreation(){

	yield return new WaitForSeconds(1);
		while (index < siz) {
			cubo.Create (cube,pos[Random.Range(0,pos.Length-1)],letter[index]);
			//Generate ();
			index++;
				}
			}
	}

	
	

	

