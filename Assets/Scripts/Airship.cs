﻿using UnityEngine;
using System.Collections;

public class Airship : MonoBehaviour {
	private float health = 0;
	// Use this for initialization
	void Start () {
		health = 1000;
	}

	public float Health {
		get { return health; }
		set { health = value; }
	}

	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision collision) {
		float dmg = collision.gameObject.GetComponent<Rocket>().Damage;
		Health -= dmg;

		if (Health < 1) {
			Destroy(gameObject, 0);
		}
	}

}
