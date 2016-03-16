using UnityEngine;
using System.Collections;

public class SlowMotionPower : MonoBehaviour {
	public float SlowMotionActive = 0.5f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey (KeyCode.F)) {
			Time.timeScale = SlowMotionActive;
		} else 
		{
			Time.timeScale = 1;
		}

	}
}
