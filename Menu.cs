using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour {

	void Start(){
		
	}

	void Update () {
		

	}

	 void OnMouseDown(){
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}


	// Use this for initialization

	
	// Update is called once per frame


