using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TeleportScript : MonoBehaviour {

	public GameObject player;
	
	void OnTriggerEnter(Collider other) {

		if (other.tag == "Player") return;

		GetComponent<Rigidbody>().velocity = Vector3.zero;

		NavMeshHit hit;
		if (NavMesh.SamplePosition(transform.position,out hit, 1,1)) {
			player.transform.position = hit.position;
		}
		
		gameObject.SetActive (false);
	}
}
