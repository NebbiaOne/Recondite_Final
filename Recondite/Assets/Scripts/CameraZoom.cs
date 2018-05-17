using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

	public Transform playerCam, character, cameraBase;
	public float zoom;
	public float zoomSpeed = 8;
	public float zoomMin = -10f;
	public float ZoomMax = -3f;
	void Start () {
		
		zoom = -3;
	}
	
	
	void Update () {
		
		zoom += Input.GetAxis ("Mouse ScrollWheel") * zoomSpeed;
		if (zoom > zoomMin)
			zoom = zoomMin;

		if (zoom < ZoomMax)
			zoom = ZoomMax;

		//playerCam.transform.localPosition = new Vector3 (0, 0, zoom);

	}
}
