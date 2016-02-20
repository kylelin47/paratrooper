using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour {
	private Rigidbody rbody;
	private GameController gc;
	private bool parachuteActive;
	private GameObject parachute;

	public float parachuteHeight;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
		gc = (GameController) FindObjectOfType(typeof(GameController));
		parachute = GameObject.FindWithTag ("Parachute");
		parachute.SetActive (false);
		parachuteActive = false;
	}

	// Update is called once per frame
	void Update () {
		// at the right height, hit the key
		if (!parachuteActive && gc.GetInteractionKey () && transform.position.y < parachuteHeight) {
			parachuteActive = true;
			parachute.SetActive (true);
		}
		if (parachuteActive) {
			if (rbody.drag < 20) {
				rbody.drag += (Time.deltaTime * 4);
			}
		}
		// hit the water
		if (transform.position.y < 5) {
			rbody.velocity = Vector3.zero;
			// rbody.useGravity = false;
		}
	}

	private void DeployParachute() {

	}
}
