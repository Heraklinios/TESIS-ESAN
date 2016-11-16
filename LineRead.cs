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
	public string randomWord;
	int totalW;
	public int totalC;
	public int lineIndex;
	void Start ()
	{
		
		lineaString = vocTexto.text;
		eachLine = new List<string> ();
		eachLine.AddRange (lineaString.Split ("\n" [0]));
		totalW = eachLine.Capacity;
	
		//Busca una palabra en random de la lista
		eachLine.RemoveAt(eachLine.Capacity-1);
		randomWord = eachLine[Random.Range(0,totalW-1)];
		lineIndex = eachLine.IndexOf (randomWord);
		eachLetter = randomWord.ToCharArray ();
		letters.AddRange (eachLetter);
		letters.RemoveAt (eachLetter.Length-1);
		totalC = letters.Capacity-1;

		}
		
		 

	void Update () {
		
	}

		
	}

	


	


