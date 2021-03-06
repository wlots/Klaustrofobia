﻿using UnityEngine;
using System.Collections;

public class StationAction : MonoBehaviour {

	public GameObject StationBullet;
	public float cdTime;
	private float timer;
	private AudioSource audioSou;

	// Use this for initialization
	void Start () {
		//cdTime = 1.0f;
		timer = 0.01f;
		audioSou = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer > cdTime) {
			Instantiate(StationBullet,transform.position, transform.rotation);
			audioSou.Play();
			timer = 0f;
		}
	}
}
