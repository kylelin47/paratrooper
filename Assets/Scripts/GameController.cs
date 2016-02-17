using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool GetInteractionKey() {
		return (Input.GetKeyDown (KeyCode.Space) || Input.GetButtonDown("Fire1"));
	}
}
