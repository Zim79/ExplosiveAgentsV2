using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {
	public float respawnTimer;
	// Use this for initialization
	void Start () {
	
	}

	IEnumerator respawnPlayer (){
		yield return new WaitForSeconds (respawnTimer);
		Application.LoadLevel (Application.loadedLevel);
	}

	public void respawn(){
		StartCoroutine (respawnPlayer ());
	}





	// Update is called once per frame
	void Update () {
	
	}
}
