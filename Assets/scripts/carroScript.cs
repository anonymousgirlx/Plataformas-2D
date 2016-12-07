using UnityEngine;
using System.Collections;

public class carroScript : MonoBehaviour { //Sin terminar
	public float velocidad = 10;
	private Rigidbody2D rb;
	public bool derecha = false;

	void Start () {
	
	}

	void Update () {
		if (derecha) {
			rb.velocity = new Vector2 (velocidad, 0);
		} else {
			
		}
	}
}
