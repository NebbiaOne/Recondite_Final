using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeviceScript : MonoBehaviour {

	public GameObject player;
	
	void OnTriggerEnter(Collider other) {

		if (other.tag == "Player") return;

		GetComponent<Rigidbody>().velocity = Vector3.zero;

	}
}
