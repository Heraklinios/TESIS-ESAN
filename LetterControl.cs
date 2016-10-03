using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class LetterControl : MonoBehaviour {
	
	public Vector2[] posiciones = new Vector2[20];
	public float speed;
	public float delay = 1;
	public int rdmnArr;
	public float xp;
	public float yp;
//public List<char> letra;
	public int lengthLetra;
	int lengthObj;
	// Use this for initialization

	void Start () {
		xp = Random.Range (-19, 19);
		yp = Random.Range (5, 20);

		rdmnArr = Random.Range (0, posiciones.Length - 1);

		RandomPos ();
		//obj.GetComponent<BoxCollider2D> ().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		
			
			//obj.GetComponent<BoxCollider2D> ().enabled = true;
	//		StartCoroutine (startPos ());



	}
	//IEnumerator startPos(){
		
	//	yield return new WaitForSeconds(delay);
	//	transform.position = Vector2.MoveTowards (this.gameObject.transform.position, posiciones[rdmnArr], speed * Time.deltaTime);
	//	yield return new WaitForSeconds(delay);

	//	yield return 0;

	//}

	void RandomPos(){
		for(int i = 0; i < 20; i++){
			xp = Random.Range (-19, 19);
			yp = Random.Range (5, 20);
			posiciones[i] = new Vector2(xp,yp);

		}
	}






}
