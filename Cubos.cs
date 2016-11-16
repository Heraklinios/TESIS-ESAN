using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cubos {
	private List<Sprite> splist;
	private BoxCollider2D bxc2D;
//	private MeshRenderer mshRen;
//	private TextMesh txtMsh;
	private SpriteRenderer sprt;
	private static List<Vector2> _posList;
	public char chr;
	public static List<Vector2> posList {
		get {
			return _posList;
		}
		set {
			_posList = value;
		}
	}

	public Cubos(){
		posList = new List<Vector2> ();
	}
		

	public void Create(Vector2 v2, char c){
		GameObject obj = new GameObject ();
		obj.gameObject.tag = "Letter";
		chr = c;
		string s = chr.ToString ();
		obj.gameObject.name = s;
		obj.gameObject.transform.position = v2;
		obj.transform.localScale += new Vector3 (0.5f, 0.5f, 0);
		bxc2D = obj.AddComponent<BoxCollider2D>() as BoxCollider2D;
		sprt = obj.AddComponent<SpriteRenderer> () as SpriteRenderer;
		switch (s) {
		case "A":
			sprt.sprite = Resources.Load ("Letter_A", typeof(Sprite)) as Sprite;
			;
			break;

		case "B":
			sprt.sprite = Resources.Load ("Letter_B", typeof(Sprite)) as Sprite;
			;
			break;

		case "C":
			sprt.sprite = Resources.Load ("Letter_C", typeof(Sprite)) as Sprite;
			;
			break;

		case "D":
			sprt.sprite = Resources.Load ("Letter_D", typeof(Sprite)) as Sprite;
			;
			break;

		case "E":
			sprt.sprite = Resources.Load ("Letter_E", typeof(Sprite)) as Sprite;
			;
			break;

		case "F":
			sprt.sprite = Resources.Load ("Letter_F", typeof(Sprite)) as Sprite;
			;
			break;

		case "G":
			sprt.sprite = Resources.Load ("Letter_G", typeof(Sprite)) as Sprite;
			;
			break;

		case "H":
			sprt.sprite = Resources.Load ("Letter_H", typeof(Sprite)) as Sprite;
			;
			break;

		case "I":
			sprt.sprite = Resources.Load ("Letter_I", typeof(Sprite)) as Sprite;
			;
			break;

		case "J":
			sprt.sprite = Resources.Load ("Letter_J", typeof(Sprite)) as Sprite;
			;
			break;

		case "K":
			sprt.sprite = Resources.Load ("Letter_K", typeof(Sprite)) as Sprite;
			;
			break;

		case "L":
			sprt.sprite = Resources.Load ("Letter_L", typeof(Sprite)) as Sprite;
			;
			break;

		case "M":
			sprt.sprite = Resources.Load ("Letter_M", typeof(Sprite)) as Sprite;
			;
			break;

		case "N":
			sprt.sprite = Resources.Load ("Letter_N", typeof(Sprite)) as Sprite;
			;
			break;

		case "O":
			sprt.sprite = Resources.Load ("Letter_O", typeof(Sprite)) as Sprite;
			;
			break;

		case "P":
			sprt.sprite = Resources.Load ("Letter_P", typeof(Sprite)) as Sprite;
			;
			break;

		case "Q":
			sprt.sprite = Resources.Load ("Letter_Q", typeof(Sprite)) as Sprite;
			;
			break;

		case "R":
			sprt.sprite = Resources.Load ("Letter_R", typeof(Sprite)) as Sprite;
			;
			break;

		case "S":
			sprt.sprite = Resources.Load ("Letter_S", typeof(Sprite)) as Sprite;
			;
			break;

		case "T":
			sprt.sprite = Resources.Load ("Letter_T", typeof(Sprite)) as Sprite;
			;
			break;

		case "U":
			sprt.sprite = Resources.Load ("Letter_U", typeof(Sprite)) as Sprite;
			;
			break;

		case "V":
			sprt.sprite = Resources.Load ("Letter_V", typeof(Sprite)) as Sprite;
			;
			break;

		case "W":
			sprt.sprite = Resources.Load ("Letter_W", typeof(Sprite)) as Sprite;
			;
			break;

		case "X":
			sprt.sprite = Resources.Load ("Letter_X", typeof(Sprite)) as Sprite;
			;
			break;

		case "Y":
			sprt.sprite = Resources.Load ("Letter_Y", typeof(Sprite)) as Sprite;
			;
			break;

		case "Z":
			sprt.sprite = Resources.Load ("Letter_Z", typeof(Sprite)) as Sprite;
			;
			break;
		}
			
	//	mshRen = obj.AddComponent<MeshRenderer> () as MeshRenderer;
	//	txtMsh = obj.AddComponent<TextMesh> () as TextMesh;
	//	txtMsh.anchor = TextAnchor.MiddleCenter;
	//	txtMsh.alignment = TextAlignment.Center;
	//	txtMsh.text = c.ToString ();


		bxc2D.isTrigger = true;
		obj.AddComponent<LetterBehavior> ();
		Vector2 pos = new Vector2 (Random.Range (-19, 19), Random.Range (5, 20));
		while (_posList.FindIndex(delegate(Vector2 p) {
			return p == pos;
		}) != -1){
			pos = new Vector2 (Random.Range (-19, 19), Random.Range (5, 20));
		}
		_posList.Add (pos);
}
	public void ShowCreate(Vector2 vc2, char c){
		GameObject obx = new GameObject ();
		chr = c;
		string s = chr.ToString ();
		obx.gameObject.tag = "Show";
		obx.gameObject.transform.position = vc2;
		obx.gameObject.name = s;
		obx.transform.localScale += new Vector3 (2, 2, 0);
		sprt = obx.AddComponent<SpriteRenderer> () as SpriteRenderer;
		switch (s) {
		case "A":
			sprt.sprite = Resources.Load ("Letter_A", typeof(Sprite)) as Sprite;
			;
			break;

		case "B":
			sprt.sprite = Resources.Load ("Letter_B", typeof(Sprite)) as Sprite;
			;
			break;

		case "C":
			sprt.sprite = Resources.Load ("Letter_C", typeof(Sprite)) as Sprite;
			;
			break;

		case "D":
			sprt.sprite = Resources.Load ("Letter_D", typeof(Sprite)) as Sprite;
			;
			break;

		case "E":
			sprt.sprite = Resources.Load ("Letter_E", typeof(Sprite)) as Sprite;
			;
			break;

		case "F":
			sprt.sprite = Resources.Load ("Letter_F", typeof(Sprite)) as Sprite;
			;
			break;

		case "G":
			sprt.sprite = Resources.Load ("Letter_G", typeof(Sprite)) as Sprite;
			;
			break;

		case "H":
			sprt.sprite = Resources.Load ("Letter_H", typeof(Sprite)) as Sprite;
			;
			break;

		case "I":
			sprt.sprite = Resources.Load ("Letter_I", typeof(Sprite)) as Sprite;
			;
			break;

		case "J":
			sprt.sprite = Resources.Load ("Letter_J", typeof(Sprite)) as Sprite;
			;
			break;

		case "K":
			sprt.sprite = Resources.Load ("Letter_K", typeof(Sprite)) as Sprite;
			;
			break;

		case "L":
			sprt.sprite = Resources.Load ("Letter_L", typeof(Sprite)) as Sprite;
			;
			break;

		case "M":
			sprt.sprite = Resources.Load ("Letter_M", typeof(Sprite)) as Sprite;
			;
			break;

		case "N":
			sprt.sprite = Resources.Load ("Letter_N", typeof(Sprite)) as Sprite;
			;
			break;

		case "O":
			sprt.sprite = Resources.Load ("Letter_O", typeof(Sprite)) as Sprite;
			;
			break;

		case "P":
			sprt.sprite = Resources.Load ("Letter_P", typeof(Sprite)) as Sprite;
			;
			break;

		case "Q":
			sprt.sprite = Resources.Load ("Letter_Q", typeof(Sprite)) as Sprite;
			;
			break;

		case "R":
			sprt.sprite = Resources.Load ("Letter_R", typeof(Sprite)) as Sprite;
			;
			break;

		case "S":
			sprt.sprite = Resources.Load ("Letter_S", typeof(Sprite)) as Sprite;
			;
			break;

		case "T":
			sprt.sprite = Resources.Load ("Letter_T", typeof(Sprite)) as Sprite;
			;
			break;

		case "U":
			sprt.sprite = Resources.Load ("Letter_U", typeof(Sprite)) as Sprite;
			;
			break;

		case "V":
			sprt.sprite = Resources.Load ("Letter_V", typeof(Sprite)) as Sprite;
			;
			break;

		case "W":
			sprt.sprite = Resources.Load ("Letter_W", typeof(Sprite)) as Sprite;
			;
			break;

		case "X":
			sprt.sprite = Resources.Load ("Letter_X", typeof(Sprite)) as Sprite;
			;
			break;

		case "Y":
			sprt.sprite = Resources.Load ("Letter_Y", typeof(Sprite)) as Sprite;
			;
			break;

		case "Z":
			sprt.sprite = Resources.Load ("Letter_Z", typeof(Sprite)) as Sprite;
			;
			break;
		}
		//Color cubeColor = new Color (Random.value, Random.value, Random.value, 1f);
		sprt.color = Color.blue;
	}

	public void CollectedCreate(Vector2 vc2, string s){
		GameObject ob = new GameObject ();
		ob.gameObject.tag = "Collected";
		ob.gameObject.transform.position = vc2;
		ob.gameObject.name = s;
		sprt = ob.AddComponent<SpriteRenderer> () as SpriteRenderer;
		switch (s) {
		case "A":
			sprt.sprite = Resources.Load ("Letter_A", typeof(Sprite)) as Sprite;
			;
			break;

		case "B":
			sprt.sprite = Resources.Load ("Letter_B", typeof(Sprite)) as Sprite;
			;
			break;

		case "C":
			sprt.sprite = Resources.Load ("Letter_C", typeof(Sprite)) as Sprite;
			;
			break;

		case "D":
			sprt.sprite = Resources.Load ("Letter_D", typeof(Sprite)) as Sprite;
			;
			break;

		case "E":
			sprt.sprite = Resources.Load ("Letter_E", typeof(Sprite)) as Sprite;
			;
			break;

		case "F":
			sprt.sprite = Resources.Load ("Letter_F", typeof(Sprite)) as Sprite;
			;
			break;

		case "G":
			sprt.sprite = Resources.Load ("Letter_G", typeof(Sprite)) as Sprite;
			;
			break;

		case "H":
			sprt.sprite = Resources.Load ("Letter_H", typeof(Sprite)) as Sprite;
			;
			break;

		case "I":
			sprt.sprite = Resources.Load ("Letter_I", typeof(Sprite)) as Sprite;
			;
			break;

		case "J":
			sprt.sprite = Resources.Load ("Letter_J", typeof(Sprite)) as Sprite;
			;
			break;

		case "K":
			sprt.sprite = Resources.Load ("Letter_K", typeof(Sprite)) as Sprite;
			;
			break;

		case "L":
			sprt.sprite = Resources.Load ("Letter_L", typeof(Sprite)) as Sprite;
			;
			break;

		case "M":
			sprt.sprite = Resources.Load ("Letter_M", typeof(Sprite)) as Sprite;
			;
			break;

		case "N":
			sprt.sprite = Resources.Load ("Letter_N", typeof(Sprite)) as Sprite;
			;
			break;

		case "O":
			sprt.sprite = Resources.Load ("Letter_O", typeof(Sprite)) as Sprite;
			;
			break;

		case "P":
			sprt.sprite = Resources.Load ("Letter_P", typeof(Sprite)) as Sprite;
			;
			break;

		case "Q":
			sprt.sprite = Resources.Load ("Letter_Q", typeof(Sprite)) as Sprite;
			;
			break;

		case "R":
			sprt.sprite = Resources.Load ("Letter_R", typeof(Sprite)) as Sprite;
			;
			break;

		case "S":
			sprt.sprite = Resources.Load ("Letter_S", typeof(Sprite)) as Sprite;
			;
			break;

		case "T":
			sprt.sprite = Resources.Load ("Letter_T", typeof(Sprite)) as Sprite;
			;
			break;

		case "U":
			sprt.sprite = Resources.Load ("Letter_U", typeof(Sprite)) as Sprite;
			;
			break;

		case "V":
			sprt.sprite = Resources.Load ("Letter_V", typeof(Sprite)) as Sprite;
			;
			break;

		case "W":
			sprt.sprite = Resources.Load ("Letter_W", typeof(Sprite)) as Sprite;
			;
			break;

		case "X":
			sprt.sprite = Resources.Load ("Letter_X", typeof(Sprite)) as Sprite;
			;
			break;

		case "Y":
			sprt.sprite = Resources.Load ("Letter_Y", typeof(Sprite)) as Sprite;
			;
			break;

		case "Z":
			sprt.sprite = Resources.Load ("Letter_Z", typeof(Sprite)) as Sprite;
			;
			break;
		}
		sprt.color = Color.green;
	}


}



