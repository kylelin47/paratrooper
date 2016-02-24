using UnityEngine;
using System.Collections;
public class DoorAnimation : MonoBehaviour {

	private Animator anim;
	private GameController gc;
	private GameObject door;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> (); 
		gc = (GameController) FindObjectOfType(typeof(GameController));
		door = GameObject.FindWithTag ("Door");
		anim.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (gc.GetInteractionKey () && door.transform.eulerAngles.y == 0) {
			anim.enabled = true;
		}
	}
}
