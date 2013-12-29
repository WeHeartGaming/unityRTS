using UnityEngine;
using System.Collections;

public class User : MonoBehaviour {

	public GameObject camera;
	public GameObject tower;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis ("MouseLeft") == 1) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);      
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.gameObject.name == "Plane") {
					Debug.DrawLine(camera.transform.position, hit.point);
					GameObject clone = Instantiate(tower, hit.point, tower.transform.rotation) as GameObject;
				}
			}
		}
	}
}
