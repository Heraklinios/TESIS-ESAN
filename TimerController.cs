using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

	public Text timer;
	public float countdown;
	public float countdownNormal;
	float tiempo = 0;
	int tiempoInt;
	// Use this for initialization
	void Start () {
		countdown = 45;
		countdownNormal = countdown;
		timer.text = "TIME: ";
	}

	// Update is called once per frame
	void Update () {
		tiempo += Time.deltaTime;

		tiempoInt = (int) tiempo;
		if (countdownNormal > 0) {
			countdownNormal = countdown - tiempoInt;
		}
		timer.text = "TIME : " + countdownNormal.ToString();
		if (tiempoInt >= 15) {
			timer.color = Color.red;
		}
	}
}
