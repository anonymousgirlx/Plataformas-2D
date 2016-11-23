using UnityEngine;
using System.Collections;

public class moneda : MonoBehaviour {

	private Rigidbody2D rb;

	void Start (){
		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (new Vector2 (Random.Range (-200, 200), Random.Range (50, 100)));
	}
	

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
}

