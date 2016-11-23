using UnityEngine;
using System.Collections;

public class generador : MonoBehaviour {
	public GameObject[] monedas;
	private Transform pos_salida;
	private GameObject moneda_nueva;
	private GameObject monedaNueva;
	private int numero_moneda = 0;

	void Start(){
		pos_salida = transform.Find ("salida").transform;
		Debug.Log ("Cantidad de monedas: " + monedas.Length);
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player" && moneda_nueva == null) {
			numero_moneda = Random.Range (0, monedas.Length - 1);
			moneda_nueva = (GameObject)Instantiate (monedas[numero_moneda],
				pos_salida.position,
				transform.rotation);
		}
	}

	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.tag == "Player" && monedaNueva == null) {
			monedaNueva = (GameObject)Instantiate (monedas[0],
				transform.position,
				transform.rotation);
		}
	}
}
			
