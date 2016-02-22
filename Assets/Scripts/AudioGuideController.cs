using UnityEngine;
using System.Collections;

public class AudioGuideController : MonoBehaviour {
	public AudioClip introduction;
	public AudioClip freeFall;
	public AudioClip parachuteOpen;

	private CardboardAudioSource audioSource;
	private GameController gc;
	private bool[] flags;
	// Use this for initialization
	void Start () {
		flags = new bool[3];
		gc =  (GameController) FindObjectOfType(typeof(GameController));
		audioSource = GetComponent<CardboardAudioSource> ();
		audioSource.clip = introduction;
		audioSource.Play ();
		flags [0] = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (!audioSource.isPlaying) {
			if (gc.playerActive && !flags [1]) {
				audioSource.clip = freeFall;
				audioSource.Play ();
				flags [1] = true;
			} else if (gc.parachuteActive && !flags [2]) {
				audioSource.clip = parachuteOpen;
				audioSource.Play ();
				flags [2] = true;
			}
		}
	}
}
