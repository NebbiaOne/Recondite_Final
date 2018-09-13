using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceConstant : MonoBehaviour {

	[SerializeField] float vBounce = 700;
	[SerializeField] float hBounce = 500;
	public AudioClip Boing;
    AudioSource audioSource;
	void Start () {

		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {

		other.rigidbody.AddForce (hBounce, vBounce, 0);
			audioSource.PlayOneShot(Boing, 0.7F);
		}
}
