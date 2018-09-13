using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWPlayerCollision : MonoBehaviour {

	// Use this for initialization
	public AudioClip Clip;
    AudioSource audioSource;
	public GameObject source;
	void Start () {
		
		audioSource = gameObject.GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

	
		
	}
		void OnCollisionEnter(Collision other) {

			audioSource.PlayOneShot(Clip, 0.7F);
		}
}
