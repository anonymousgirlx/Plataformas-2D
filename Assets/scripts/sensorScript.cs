using UnityEngine;
using System.Collections;

public class sensorScript : MonoBehaviour {
	public carroScript cs;

	void OnTriggerEnter2D(Collider2D col){
		cs.derecha = !cs.derecha;
	}
}
