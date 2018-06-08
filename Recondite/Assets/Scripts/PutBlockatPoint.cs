using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutBlockatPoint : MonoBehaviour {
	public GameObject obj;
	public GameObject Camera;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		//if (Physics.Raycast (transform.position, Vector3.down, out hit))
	/*	if (Physics.Raycast (Camera.main.ScreenPointToRay (Input.mousePosition), out hit)) {
			if (hit.collider != GetComponent<Collider> () && hit.transform.tag == "Floor")
				obj.transform.position = hit.point;
		} */
		if (Physics.Raycast (Camera.transform.position, Camera.transform.forward, out hit)) {
			if (hit.collider != GetComponent<Collider> () && hit.transform.tag == "Floor")
				obj.transform.position = hit.point;

		}
	}
}