using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


	public GameObject player;
	public GameObject exitPoint,bullet;
	float timer;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		float distance = Vector3.Distance (player.transform.position, transform.position);
		print (distance);

		if (distance < 10) {
			print("Bang");

			if(timer > 2){
			

			GameObject temp = Instantiate(bullet) as GameObject;
			temp.transform.position = exitPoint.transform.position;
			
				temp.GetComponent < Rigidbody2D > ().velocity = Vector2.left * 50;

			timer = 0;
			
			}
		}



	}
}
