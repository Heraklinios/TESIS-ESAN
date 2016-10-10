using UnityEngine;
using System.Collections;


public class Cubos {

	private BoxCollider2D bxc2D;
	private MeshRenderer mshRen;
	private TextMesh txtMsh;


	public Cubos(){
		
	}


	//public void SetDestination(Vector2 v2){
	//	go.transform.position = v2;
	//}

	public void Create(Vector2 v2, char c){
		GameObject obj = new GameObject ();
		obj.gameObject.tag = "Letter";

		obj.gameObject.transform.position = v2;
		bxc2D = obj.AddComponent<BoxCollider2D>() as BoxCollider2D;
		mshRen = obj.AddComponent<MeshRenderer> () as MeshRenderer;
		txtMsh = obj.AddComponent<TextMesh> () as TextMesh;
		txtMsh.anchor = TextAnchor.MiddleCenter;
		txtMsh.alignment = TextAlignment.Center;
		txtMsh.text = c.ToString ();

}

	public void Move(GameObject obj, Vector2 v2nuevo){
		obj.transform.position = Vector2.MoveTowards(obj.transform.position,v2nuevo, 5*Time.deltaTime);
			}
}