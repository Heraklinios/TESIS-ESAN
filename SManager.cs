using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SManager : MonoBehaviour {
	GameObject timer;
	public int letColect;
	//GameObject[] totalLetters;
	int cantLetras;
	int trigger = 0;
	// Use this for initialization
	void Start () {
		timer = GameObject.Find ("Timer");
        cantLetras = GameObject.Find("TextMng").GetComponent<LineRead>().letters.Capacity;
        
        Debug.Log(cantLetras);
        //totalLetters = GameObject.FindGameObjectsWithTag ("Letter");

        //timer.GetComponent<TimerCount> ().countdownNormal = 120;
    }

	// Update is called once per frame
	void Update () {
       
        letColect = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ().letterCount;
		//cantLetras = totalLetters.Length;
	
		if (timer.GetComponent<TimerController> ().countdownNormal == trigger || letColect >= cantLetras -1) {
	
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
