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
		// spacebar and left mouse button on keyboard and X on PS4 controller
		return (Input.GetKeyDown (KeyCode.Space) || Input.GetButtonDown("Fire1") || Input.GetButtonDown("joystick button 1"));
	}

	public bool OpenDoorKey() {
		// Z on keyboard and O on PS4 controller
		return (Input.GetKeyDown(KeyCode.Z) || Input.GetButtonDown("joystick button 2"));
	}

	public bool SkydiveKey() {
		// X on keyboard and Triangle on PS4 controller
		return (Input.GetKeyDown (KeyCode.X) || Input.GetButtonDown ("joystick button 3"));
	}

	public bool AltitudeKey() {
		// C on keyboard and Square on PS4 controller
		return (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown("joystick button 4"));
	}

}
