using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	// Use this for initialization
	public bool parachuteActive;
	public float playerVelocity;
	CardboardAudioSource wind;
	void Start () {
		wind = GameObject.FindWithTag ("MainCamera").GetComponent<CardboardAudioSource>();
		wind.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		wind.volume = playerVelocity > 100 ? 1 : playerVelocity/100;
	}

	public bool GetInteractionKey() {
		return (Input.GetKeyDown (KeyCode.Space) || Input.GetButtonDown("Fire1"));
	}
}
