using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour {
	private Rigidbody rbody;
	private GameController gc;
	private GameObject parachute;

	public float horizontalSpeed = 10;
	public float maximumDrag;
	public float parachuteHeight;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
		gc = (GameController) FindObjectOfType(typeof(GameController));
		parachute = GameObject.FindWithTag ("Parachute");
		parachute.SetActive (false);
		gc.parachuteActive = false;
	}

	// Update is called once per frame
	void Update () {
		if (gc.playerActive) {
			gc.playerVelocity = rbody.velocity.magnitude;
			// at the right height, hit the key
			if (!gc.parachuteActive && gc.GetInteractionKey () && transform.position.y < parachuteHeight) {
				gc.parachuteActive = true;
				parachute.SetActive (true);
			}
			if (gc.parachuteActive) {
				if (rbody.drag < maximumDrag) {
					rbody.drag += (Time.deltaTime * maximumDrag / 5);
				}
			}
		}
	}

	void FixedUpdate() {
		if (gc.playerActive) {
			rbody.AddForce (Camera.main.transform.right * horizontalSpeed * Input.GetAxis ("Horizontal"));
		}
	}
}
