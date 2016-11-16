using UnityEngine;
using System.Collections;

public class BGColor : MonoBehaviour {


	SpriteRenderer sprt;
	GameObject timer;
	// Use this for initialization
	void Start () {
		sprt = GetComponent<SpriteRenderer> ();
		sprt.color = Color.gray;
		sprt.sprite = Resources.Load<Sprite> ("Clock");
		timer = GameObject.FindGameObjectWithTag ("Timer");
	}
	
	// Update is called once per frame
	void Update () {
		if(timer.activeInHierarchy == false){
			sprt.sprite = Resources.Load<Sprite> ("Sky");
			sprt.color = Color.white;
	}
	}
}
