using UnityEngine;
using System.Collections;

public class InGameGUI : MonoBehaviour {

	public Texture2D logo;
	public GUIStyle style;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnGUI () {
		GUI.Label (new Rect (10, 10, 34, 34), new GUIContent(logo), style);
	}
}
