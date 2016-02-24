using UnityEngine;
using System.Collections;

public class JumpAnimation : MonoBehaviour {
	
	private Animator anim;
	private GameController gc;
	private GameObject player;
	private GameObject door;
	private GameObject plane;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> (); 
		gc = (GameController) FindObjectOfType(typeof(GameController));
		player = GameObject.FindWithTag ("Player");
		door = GameObject.FindWithTag ("Door");
		plane = GameObject.FindWithTag ("Plane");
		anim.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (gc.GetInteractionKey () && door.transform.eulerAngles.y == 270) {
			anim.enabled = true;
		}
		if (player.transform.position.y < 2195) {
			anim.enabled = false;
			gc.playerActive = true;
			plane.transform.Translate (Vector3.right * 50 * Time.deltaTime);
		}
	}

}