using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ControllerLetter : MonoBehaviour {
	private Cubos cubo;
	public List<char> letter;
	//public GameObject cube;
	public List<GameObject> cubosGenerados;
	List<GameObject> cubosEjemplo;
	GameObject plyr;
	GameObject[] spawn;
	GameObject[] platforms;
	GameObject[] buttons;
	GameObject timer;
	GameObject[] fall;
	GameObject[] mplat;
	GameObject ans;
	public int actTime;
	int index = 0;
	int index2 = 0;
	int lineIndex;
	float increment = 1.5f;
	public int siz;
	//float delay = 1;
	// Use this for initialization

	void Start () {
		plyr = GameObject.FindGameObjectWithTag ("Player");
		spawn = GameObject.FindGameObjectsWithTag ("Spawn");
		platforms = GameObject.FindGameObjectsWithTag ("Platform");
		fall = GameObject.FindGameObjectsWithTag ("Fall");
		mplat = GameObject.FindGameObjectsWithTag ("Moving");
		buttons = GameObject.FindGameObjectsWithTag ("Button");
		cubo = new Cubos();
		cubosGenerados = new List<GameObject> ();
		cubosEjemplo = new List<GameObject> ();
		letter = GameObject.Find ("TextMng").GetComponent<LineRead> ().letters;
		timer = GameObject.FindGameObjectWithTag ("Timer");

		Invoke("Create",0);
		Invoke ("PopUp", 1);
		StartCoroutine (Activate ());

	}

	// Update is called once per frame
	void Update () {
		if (letter.Capacity - 1 < 6) {
			actTime = 10;
		} else {
			actTime = 15;
		}
		if(timer.activeInHierarchy == false){
			StartCoroutine (Hide ());
		}
	}


	void PopUp(){
		siz = GameObject.Find ("TextMng").GetComponent<LineRead> ().totalC;

		float incrementX = 5f;
		while (index < siz) {
			cubo.ShowCreate (new Vector2((index*6) -29 + incrementX,20),letter[index]);
			increment = increment + 3f;
			index++;
		}
		cubosEjemplo.AddRange(GameObject.FindGameObjectsWithTag ("Show"));
		CreateWord ();
	}

	void Create(){
		siz = GameObject.Find ("TextMng").GetComponent<LineRead> ().totalC;
		plyr.SetActive (false);
		foreach (GameObject bx in spawn) {
			bx.SetActive (false);
		}
		foreach (GameObject px in platforms) {
			px.SetActive (false);
		}
		foreach (GameObject fx in fall) {
			fx.SetActive (false);
		}
		foreach (GameObject m in mplat) {
			m.SetActive (false);
		}
		foreach (GameObject b in buttons) {
			b.SetActive (false);
		}
		while (index2 < siz) {
			cubo.Create (new Vector2(index2 - siz + increment,20),letter[index2]);
			increment = increment + 1.5f;
			index2++;
		}
		cubosGenerados.AddRange(GameObject.FindGameObjectsWithTag ("Letter"));

	
}
		

	IEnumerator Activate(){
		yield return new WaitForSeconds (0);
		foreach (GameObject obj in cubosGenerados) {
			obj.SetActive (false);
		}
		yield return new WaitForSeconds (actTime);
		foreach (GameObject obj in cubosGenerados) {
			obj.SetActive (true);
		}
	}

	IEnumerator Hide(){
		yield return new WaitForSeconds (0);
			foreach(GameObject obj in cubosEjemplo){
			obj.SetActive (false);
			ans.SetActive (false);
				}	

		plyr.SetActive (true);
		foreach (GameObject bx in spawn) {
			bx.SetActive (true);
		}
		foreach (GameObject px in platforms) {
			px.SetActive (true);
		}
		foreach (GameObject fx in fall) {
			fx.SetActive (true);
		}
		foreach (GameObject m in mplat) {
			m.SetActive (true);
		}
		foreach (GameObject b in buttons) {
			b.SetActive (true);
		}
	}

	void CreateWord(){
		lineIndex = GameObject.Find ("TextMng").GetComponent<LineRead> ().lineIndex;
		switch (lineIndex) {
		case 0:
			ans = Instantiate (Resources.Load ("Diffuse_Ans", typeof(GameObject))) as GameObject;
			ans.gameObject.transform.position = new Vector2 (0,6);

			break;

		case 1:
			ans = Instantiate (Resources.Load ("Oar_Ans", typeof(GameObject))) as GameObject;
			ans.gameObject.transform.position = new Vector2 (0,6);

			break;

		case 2:
			ans = Instantiate (Resources.Load ("Landscape_Ans", typeof(GameObject))) as GameObject;
			ans.gameObject.transform.position = new Vector2 (0,6);
			break;

		case 3:
			ans = Instantiate (Resources.Load ("Oscilate_Ans", typeof(GameObject))) as GameObject;
			ans.gameObject.transform.position = new Vector2 (0,6);
			break;
		case 4: 
			ans = Instantiate (Resources.Load ("Monkey_Ans", typeof(GameObject))) as GameObject;
			ans.gameObject.transform.position = new Vector2 (0,6);
			break;
		case 5:
			ans = Instantiate (Resources.Load ("Spanner_Ans", typeof(GameObject))) as GameObject;
			ans.gameObject.transform.position = new Vector2 (0,6);
			break;
		case 6: 
			ans = Instantiate (Resources.Load ("Axis_Ans", typeof(GameObject))) as GameObject;
			ans.gameObject.transform.position = new Vector2 (0,6);
			break;
		case 7:
			ans = Instantiate (Resources.Load ("Overclock_Ans", typeof(GameObject))) as GameObject;
			ans.gameObject.transform.position = new Vector2 (0,6);
			break;
			//case 8:
			//	obj = Instantiate (Resources.Load ("Moon", typeof(GameObject))) as GameObject;
			//	obj.transform.localScale += new Vector3 (2, 2, 0); 
			//	obj.gameObject.transform.position = this.gameObject.transform.position;
			//	obj.SetActive (false);
			//	break;
		}
	}

	}


	

