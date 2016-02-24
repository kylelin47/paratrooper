using UnityEngine;
using System.Collections;

public class JumpAnimation : MonoBehaviour {
	
	private Animator anim;
	private GameController gc;
	private GameObject player;
	private GameObject door;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> (); 
		gc = (GameController) FindObjectOfType(typeof(GameController));
		player = GameObject.FindWithTag ("Player");
		door = GameObject.FindWithTag ("Door");
		anim.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (gc.SkydiveKey () && door.transform.eulerAngles.y == 270) {
			anim.enabled = true;
		}
		if (player.transform.position.y < 1495) {
			anim.enabled = false;
			gc.playerActive = true;
		}
	}

}