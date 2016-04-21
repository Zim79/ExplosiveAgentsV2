using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float enemyShootSpeed;
	public GameObject player;
	public GameObject exitPoint,bullet;
	float timer;

	bool isBurstFireOn;

	// Use this for initialization
	void Start () {

	}
	//Fires three times 
	IEnumerator burstFire() {


		for (int i=0; i<3; i++) {
			GameObject temp = Instantiate (bullet) as GameObject;
			temp.transform.position = exitPoint.transform.position;
		
			temp.GetComponent < Rigidbody2D > ().velocity = Vector2.left * enemyShootSpeed;
			//Destroys projectile
			Destroy(temp,3);
			//time between projectile spawn
			yield return new WaitForSeconds(0.2f);

		}

		timer = 0;
		isBurstFireOn = false;

	}


	// Update is called once per frame
	void Update () {


		timer += Time.deltaTime;

		float distance = Vector3.Distance (player.transform.position, transform.position);
		print (distance);

		if (distance < 8.4) {
			print("Bang");

			if(timer > 0.9){
			
			if(isBurstFireOn == false){

				StartCoroutine(burstFire ());

					isBurstFireOn = true;
				}

					
			
			
			}
		




		}



	}
}
