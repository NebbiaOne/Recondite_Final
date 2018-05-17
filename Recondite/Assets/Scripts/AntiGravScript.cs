using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravScript : MonoBehaviour {

	[SerializeField] Vector3 ImpactPoint;

	void Start () {
		
	}
	
	
	void Update () {
		
	}
	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider other) {
		
		other.GetComponent<Rigidbody>().AddForce(ImpactPoint, ForceMode.Impulse);
		
	}
}
