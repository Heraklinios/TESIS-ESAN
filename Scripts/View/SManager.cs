using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class SManager : MonoBehaviour {
	GameObject timer;
	public int letColect;

	List<char> cantLetras;
	public int totalLetters;
	int trigger = 0;
	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Timer");
		cantLetras = GameObject.Find ("TextMng").GetComponent<LineRead> ().letters;
		totalLetters = cantLetras.Capacity;

		//timer.GetComponent<TimerCount> ().countdownNormal = 120;
	}

	// Update is called once per frame
	void Update () {
		
		letColect = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().letterCount;

	
		if (timer.GetComponent<TimerController> ().countdownNormal == trigger || letColect == totalLetters -1) {
	
				if (SceneManager.GetActiveScene ().buildIndex < SceneManager.sceneCountInBuildSettings - 1) {
					SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
				}
		}
		//if ((playerManager.GetComponent<PlayerManager> ().isPlayer1Dead) && (playerManager.GetComponent<PlayerManager> ().isPlayer2Dead)) {
		//	SceneManager.LoadScene ("Menu");
		//}
	}
	// Use this for initialization


}
