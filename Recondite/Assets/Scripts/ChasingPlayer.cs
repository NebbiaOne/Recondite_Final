using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasingPlayer : MonoBehaviour {

	WaypointSystem _playerfound;

	// Use this for initialization
	void Start () {
		_playerfound = transform.parent.GetComponent<WaypointSystem>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other) {
		Debug.Log("Entered Trigger");
		if (other.gameObject.tag == "player") {
			_playerfound.playerFound = true;
			Debug.Log("Player Found");
		}
	}		
}

