using UnityEngine;
using System.Collections;

public class TestCode : MonoBehaviour {

	private Cube cube = new Cube1();

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		GUILayout.Label (cube.Experience.ToString());
		GUILayout.Label (cube.Level.ToString ());
		GUILayout.Label (cube.BaseAttack.ToString());
		GUILayout.Label (cube.EvAttack.ToString());
		GUILayout.Label (cube.Attack.ToString());
	}
}
