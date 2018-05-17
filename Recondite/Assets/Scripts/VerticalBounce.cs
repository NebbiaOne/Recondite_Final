using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBounce : MonoBehaviour {

	[SerializeField] float vBounce = 700;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {

		other.rigidbody.AddForce (0, vBounce, 0);
			
		}
}
