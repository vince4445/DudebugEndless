﻿using UnityEngine;
using System.Collections;

public class obsticle : MonoBehaviour {
	public Vector2 velocity = new Vector2 ( -4, 0);
	public float range = 5;

	void Start () {
		rigidbody2D.velocity = velocity;
		transform.position = new Vector3 (transform.position.x, transform.position.y - range * Random.value, transform.position.z);
	
	}
	

	void Update () {
	
	}
}
