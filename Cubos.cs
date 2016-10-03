﻿using UnityEngine;
using System.Collections;


public class Cubos {

	public GameObject go;
	private BoxCollider2D bxc2D;
	private MeshRenderer mshRen;
	private TextMesh txtMsh;


	public Cubos(GameObject _obj){
		go = _obj;
	}


	//public void SetDestination(Vector2 v2){
	//	go.transform.position = v2;
	//}

	public void Create(GameObject obj,Vector2 v2, char c){
		obj = new GameObject ();
		obj.gameObject.tag = "Letter";
		obj.transform.position = v2;
		bxc2D = obj.AddComponent<BoxCollider2D>() as BoxCollider2D;
		mshRen = obj.AddComponent<MeshRenderer> () as MeshRenderer;
		txtMsh = obj.AddComponent<TextMesh> () as TextMesh;
		txtMsh.anchor = TextAnchor.MiddleCenter;
		txtMsh.alignment = TextAlignment.Center;
		txtMsh.text = c.ToString ();
}
}