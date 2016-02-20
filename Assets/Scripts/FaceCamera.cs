using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {
	private ManAnimation ma;

	// Use this for initialization
	void Start () {
		ma = (ManAnimation) FindObjectOfType(typeof(ManAnimation));
	}
	
	// Update is called once per frame
	void Update () {
		if (ma.animationState == "stand") {
			var CharacterRotation = Camera.main.transform.rotation;
			CharacterRotation.x = 0;
			CharacterRotation.z = 0;
			transform.rotation = CharacterRotation;
			transform.rotation *= Quaternion.Euler (0, 180f, 0);
		}
		else if (ma.animationState == "spreadEagle") {
			var CharacterRotation = Camera.main.transform.rotation;
			CharacterRotation.x = 0;
			CharacterRotation.y = 0;
			transform.rotation = CharacterRotation;
			transform.rotation *= Quaternion.Euler (0, 0, 180f);
		}
	}
}
