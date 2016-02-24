using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public bool parachuteActive;
	public float playerVelocity;
	public float playerAltitude;
	public bool playerActive;

	CardboardAudioSource wind;
	void Start () {
		wind = GameObject.FindWithTag ("BGM").GetComponent<CardboardAudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerActive) {
			if (!wind.isPlaying) {
				wind.Play ();
			}
			wind.volume = playerVelocity > 100 ? 1 : playerVelocity / 100;
		}
	}

	public bool GetInteractionKey() {
		// spacebar and left mouse button on keyboard or X on PS4 controller
		return (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1") || Input.GetKeyDown("joystick button 1"));
	}

	public bool GetAltitudeKey() {
		// C on keyboard or Square on PS4 controller
		return (Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown("joystick button 2"));
	}

}
