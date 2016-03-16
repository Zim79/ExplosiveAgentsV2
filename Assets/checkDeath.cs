using UnityEngine;
using System.Collections;

public class checkDeath : MonoBehaviour {
	public gameController Gamecontroller;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "Death") {
			print("Death");
			Gamecontroller.respawn();
			Destroy (gameObject);
		}
	}
}
