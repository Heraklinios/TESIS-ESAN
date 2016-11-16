using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public int lastItemCollected = 0;
	float h;
	Rigidbody2D rb;
	Animator anim;
	SpriteRenderer sp;
	int speed = 28;
	public float jumpSpeed;
	float jumpBounce;
	public int jumpCount = 0;
	public int letterCount = 0;
	private GameObject instance;
	public bool isGrounded = true;
	public float axisX = -23;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		jumpBounce = jumpSpeed * 1.5f;
		sp = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.acceleration.x;
		anim.SetFloat ("Move", Mathf.Abs(h));
		if (h >= 0) {
			sp.flipX = false;
		}
		if (h < 0) {
			sp.flipX = true;
		}
		if (this.gameObject.transform.position.x <= -24) {

			transform.position = new Vector2 (24, transform.position.y);
		}

		if (this.gameObject.transform.position.x > 24) {

			transform.position = new Vector2 (-24, transform.position.y);
		}

		if (this.gameObject.transform.position.y <= -4) {

			transform.position = new Vector2 (0, 0);

		}
	}
	void FixedUpdate(){
		rb.velocity = new Vector2 (h * speed, rb.velocity.y);
		if(Input.GetTouch(0).phase == TouchPhase.Began && isGrounded == true){
			rb.AddForce (Vector2.up * jumpSpeed);
			anim.SetBool ("Jump", true);
			isGrounded = false;
			StartCoroutine(Reset ());

		}

	}
		

	void OnCollisionEnter2D(Collision2D obj){
		
		if (obj.gameObject.CompareTag ("Box")) {
			obj.gameObject.SetActive (false);
			rb.velocity = new Vector2 (rb.velocity.x, 0);
			rb.AddForce (Vector2.up * jumpBounce);


		}


	}



	//void OnTriggerEnter2D(Collider2D obj){
	//	if (obj.gameObject.CompareTag ("Letter")) {
			
//letterCount++;	

		//	obj.gameObject.SetActive (false);	
	//		instance = Instantiate (Resources.Load ("Boom", typeof(GameObject))) as GameObject;
	//		Instantiate (instance, obj.gameObject.transform.position, obj.gameObject.transform.rotation);

	//	}

	//}



	IEnumerator Reset(){
		yield return new WaitForSeconds (1);
		anim.SetBool ("Jump", false);
	}
}
