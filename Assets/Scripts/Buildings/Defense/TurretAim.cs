using UnityEngine;
using System.Collections;

public class TurretAim : MonoBehaviour {
	private Rigidbody rocket = null;
	private float lastShot = 0.0f;
	private float timer = 0.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject obj = GameObject.Find("Airship");
		if (obj) {
			Vector3 enemyPos = obj.transform.position;
			Vector3 turretPos = gameObject.transform.position;

			float dist = Vector3.Distance (enemyPos, turretPos);

			if (dist < 40) {
				gameObject.transform.LookAt(enemyPos);
				Quaternion rot = gameObject.transform.rotation;
				float deg = Mathf.Asin((9.81f * dist) / (50*50));
				deg = deg * Mathf.Rad2Deg;
				deg = deg / 2;
				//Debug.Log(deg);
				gameObject.transform.Rotate(-deg, 0, 0);
				if (lastShot < (Time.realtimeSinceStartup - timer)) {
					float vel = 50;
					gameObject.GetComponentInChildren<TurretMuzzle> ().Fire (vel);
					lastShot = Time.realtimeSinceStartup;
				}
			}
		}
	}
}
