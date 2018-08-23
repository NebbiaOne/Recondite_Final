using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceConstant : MonoBehaviour {

	[SerializeField] float vBounce = 700;
	[SerializeField] float hBounce = 500;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {

		other.rigidbody.AddForce (hBounce, vBounce, 0);
			
		}
}
