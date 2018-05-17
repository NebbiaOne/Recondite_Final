using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TossScript : MonoBehaviour {
	public Transform tossPoint;
	public GameObject pad;
	GameObject device;
	 void Start() {
		 
		device = (GameObject) Instantiate (pad);
		device.GetComponent<DeviceScript>().player = gameObject;
		device.SetActive (false);
		
	}
	void Update() {

		if(Input.GetButtonDown("Fire1")){

			device.transform.position = tossPoint.position;
			device.transform.rotation = tossPoint.rotation;
			device.SetActive(true);
			device.GetComponent<Rigidbody>().AddRelativeForce(0, 5, 7, ForceMode.Impulse);
			
		}
		
	}
}
