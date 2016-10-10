using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
public class LineRead : MonoBehaviour {

	public TextAsset vocTexto;

	private string lineaString;
	public List<string> eachLine;
	char[] eachLetter;
	public List<char> letters;
	string randomWord;
	int totalW;
	public int totalC;

	void Start ()
	{
		
		lineaString = vocTexto.text;
		eachLine = new List<string> ();
		eachLine.AddRange (lineaString.Split ("\n" [0]));
		totalW = eachLine.Capacity;
	
		//Busca una palabra en random de la lista
		randomWord = eachLine[Random.Range(0,totalW-1)];

		eachLetter = randomWord.ToCharArray ();
		letters.AddRange (eachLetter);
		letters.RemoveAt (eachLetter.Length-1);
		totalC = letters.Capacity-1;

		}
		
		 

	void Update () {
		
	

	}


	}

	// Update is called once per frame
	
		


	//void OnGUI(){
	//	for (int i = 0; i < kWords; i++) {
	//		GUILayout.Label (eachLine [i]);
	//}			
	//}


