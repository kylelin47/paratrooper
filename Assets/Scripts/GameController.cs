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
		return (Input.GetKeyDown (KeyCode.Space) || Input.GetButtonDown("Fire1"));
	}
}
