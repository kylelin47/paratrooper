using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour {
	private Rigidbody rbody;
	private GameController gc;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
		gc = (GameController) FindObjectOfType(typeof(GameController));
	}

	// Update is called once per frame
	void Update () {
		// at the right height, hit the key
		if (gc.GetInteractionKey () && transform.position.y < 10000) {
			DeployParachute ();
		}
		// hit the water
		if (transform.position.y < 5) {
			rbody.useGravity = false;
		}
	}

	void DeployParachute() {
		rbody.drag = 20;
	}
}
