using UnityEngine;
using System.Collections;
using UnityEngine.UI;

using System.Collections.Generic;

public class TimerController : MonoBehaviour {

	List<char> size;
	public Text timer;
	public float countdown;
	public float countdownNormal;
	float tiempo = 0;
	int tiempoInt;

	// Use this for initialization
	void Start () {
		size = GameObject.Find ("TextMng").GetComponent<LineRead> ().letters;
		if (size.Capacity < 6) {
			countdown = 10;
		} else {
			countdown = 15;
		}
		countdownNormal = countdown;
		timer.text = ":";
		timer.color = Color.white;
		timer.fontSize = 15;
		timer.fontStyle = FontStyle.Bold;
	}

	// Update is called once per frame
	void Update () {
		size = GameObject.Find ("TextMng").GetComponent<LineRead> ().letters;
		tiempo += Time.deltaTime;

		tiempoInt = (int) tiempo;
		if (countdownNormal > 0) {
			countdownNormal = countdown - tiempoInt;
		}
		timer.text = ": " + countdownNormal.ToString();
		if (size.Capacity < 6) {
			if (tiempoInt >= 7) {
				timer.color = Color.red;
			}

		}
		else
			if (tiempoInt >= 12) {
				timer.color = Color.red;
			}
		if(countdownNormal == 0){
			gameObject.SetActive (false);
		}
	}

}
