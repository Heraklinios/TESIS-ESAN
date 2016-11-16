using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SManager : MonoBehaviour {
	GameObject timer;
	GameObject obj;
	public int letColect;
	public int index;
	GameObject plyr;
	public List<char> cantLetras;
	public int totalLetters;
	//int trigger = 0;
	// Use this for initialization
	void Start () {
		plyr = GameObject.FindGameObjectWithTag ("Player");
	//	timer = GameObject.Find ("Timer");
		cantLetras = GameObject.Find ("TextMng").GetComponent<LineRead> ().letters;

		Invoke("CreateObject",2);
		//timer.GetComponent<TimerCount> ().countdownNormal = 120;
	}

	// Update is called once per frame
	void Update () {
		if(GameObject.FindGameObjectWithTag("Player") != null){
		totalLetters = cantLetras.Capacity;
		
		letColect = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().letterCount;

	
		//if (timer.GetComponent<TimerController> ().countdownNormal == trigger || letColect == totalLetters -1) {
			if (letColect == totalLetters -1) {
				
			obj.SetActive (true);

			StartCoroutine (EndScene ());
				
		}
		//if ((playerManager.GetComponent<PlayerManager> ().isPlayer1Dead) && (playerManager.GetComponent<PlayerManager> ().isPlayer2Dead)) {
		//	SceneManager.LoadScene ("Menu");
		//}
	}
	}
	IEnumerator EndScene(){
		plyr.SetActive (false);
		GameObject boom = Instantiate (Resources.Load ("Particles", typeof(GameObject))) as GameObject;

		yield return new WaitForSeconds (1);
		Destroy (boom, 1);

		yield return new WaitForSeconds(4);
		if (SceneManager.GetActiveScene ().buildIndex < SceneManager.sceneCountInBuildSettings - 1) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}

	void CreateObject(){
		index = GameObject.Find ("TextMng").GetComponent<LineRead> ().lineIndex;
		switch (index) {
		case 0:
			obj = Instantiate (Resources.Load ("Diffuse", typeof(GameObject))) as GameObject;
			obj.transform.localScale += new Vector3 (1, 1, 0); 
			obj.gameObject.transform.position = this.gameObject.transform.position;
			obj.SetActive (false);

			break;

		case 1:
			obj = Instantiate (Resources.Load ("Oar", typeof(GameObject))) as GameObject;
			obj.transform.localScale += new Vector3 (1, 1, 0); 
			obj.gameObject.transform.position = this.gameObject.transform.position;
			obj.SetActive (false);
			break;

		case 2:
			obj = Instantiate (Resources.Load ("Landscape", typeof(GameObject))) as GameObject;
			obj.transform.localScale += new Vector3 (1, 1, 0); 
			obj.gameObject.transform.position = this.gameObject.transform.position;
			obj.SetActive (false);
			break;

		case 3:
			obj = Instantiate (Resources.Load ("Oscilate", typeof(GameObject))) as GameObject;
			obj.transform.localScale += new Vector3 (1, 1, 0); 
			obj.gameObject.transform.position = this.gameObject.transform.position;
			obj.SetActive (false);
			break;
		case 4: 
			obj = Instantiate (Resources.Load ("Monkey", typeof(GameObject))) as GameObject;
			obj.transform.localScale += new Vector3 (1, 1, 0); 
			obj.gameObject.transform.position = this.gameObject.transform.position;
			obj.SetActive (false);
			break;
		case 5:
			obj = Instantiate (Resources.Load ("Spanner", typeof(GameObject))) as GameObject;
			obj.transform.localScale += new Vector3 (1, 1, 0); 
			obj.gameObject.transform.position = this.gameObject.transform.position;
			obj.SetActive (false);
			break;
		case 6: 
			obj = Instantiate (Resources.Load ("Axis", typeof(GameObject))) as GameObject;
			obj.transform.localScale += new Vector3 (1, 1, 0); 
			obj.gameObject.transform.position = this.gameObject.transform.position;
			obj.SetActive (false);
			break;
		case 7:
			obj = Instantiate (Resources.Load ("Overclock", typeof(GameObject))) as GameObject;
			obj.transform.localScale += new Vector3 (1, 1, 0); 
			obj.gameObject.transform.position = this.gameObject.transform.position;
			obj.SetActive (false);
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
	// Use this for initialization

