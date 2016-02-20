using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var CharacterRotation = Camera.main.transform.rotation;
		CharacterRotation.x = 0;
		CharacterRotation.z = 0;
		transform.rotation = CharacterRotation;
		transform.rotation *= Quaternion.Euler(0,180f,0);
	}
}
