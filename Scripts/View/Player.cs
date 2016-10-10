using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	float h;
	Rigidbody2D rb;
	public int speed;
	public float jumpSpeed;
	float jumpBounce;
	public int letterCount = 0;

	public bool isGrounded = true;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		jumpBounce = jumpSpeed * 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis ("Horizontal");
		if (this.gameObject.transform.position.x <= -20) {

			transform.position = new Vector2 (20, transform.position.y);
		}

		if (this.gameObject.transform.position.x > 20) {

			transform.position = new Vector2 (-20, transform.position.y);
		}

		if (this.gameObject.transform.position.y <= -4) {

			transform.position = new Vector2 (0, 0);

		}
	}
	void FixedUpdate(){
		rb.velocity = new Vector2 (h * speed, rb.velocity.y);
		if(Input.GetKey(KeyCode.Space) && isGrounded == true){
			rb.AddForce (Vector2.up * jumpSpeed);
            isGrounded = false;

		}

	}
		

	void OnCollisionEnter2D(Collision2D obj){
		
		if (obj.gameObject.CompareTag ("Box")) {
			obj.gameObject.SetActive (false);
			rb.AddForce (Vector2.up * jumpBounce);

		}
		if (obj.gameObject.CompareTag ("Letter")) {
			letterCount++;	
			obj.gameObject.SetActive (false);
		
		
		}

		if (obj.gameObject.CompareTag ("F.Platform")) {
            isGrounded = true;
		}
	}
}
