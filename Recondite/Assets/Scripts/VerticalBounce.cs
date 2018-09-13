using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBounce : MonoBehaviour {

	[SerializeField] float vBounce = 700;
	public AudioClip boing;
    AudioSource audioSource;
	void Start () {

		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other) {

		other.rigidbody.AddForce (0, vBounce, 0);
			audioSource.PlayOneShot(boing, 0.7F);
		}
}
