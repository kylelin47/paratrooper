using UnityEngine;
using System.Collections;

public class GravityController : MonoBehaviour {
	private Rigidbody rbody;
	private GameController gc;
	private GameObject parachute;

	public float horizontalSpeed = 10;
	public float maximumDrag;
	public float parachuteHeight;
	public float gravityScale;
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody> ();
		gc = (GameController) FindObjectOfType(typeof(GameController));
		parachute = GameObject.FindWithTag ("Parachute");
		parachute.SetActive (false);
		gc.parachuteActive = false;
		Physics.gravity = new Vector3(0, -9.81f * gravityScale, 0);
	}

	// Update is called once per frame
	void Update () {
		gc.playerAltitude = rbody.transform.position.y;
		if (gc.playerActive) {
			gc.playerVelocity = rbody.velocity.magnitude;
			// at the right height, hit the key
			if (!gc.parachuteActive && gc.GetInteractionKey () && transform.position.y < parachuteHeight) {
				activateParachute ();
			}
			if (gc.parachuteActive) {
				if (rbody.drag < maximumDrag) {
					rbody.drag += (Time.deltaTime * maximumDrag / 5);
				}
			}
		}
	}
	private void activateParachute() {
		gc.parachuteActive = true;
		parachute.SetActive (true);
		Physics.gravity = new Vector3(0, -9.81f, 0);
	}
	void FixedUpdate() {
		if (gc.playerActive) {
			rbody.AddForce (Camera.main.transform.right * horizontalSpeed * Input.GetAxis ("Horizontal"));
		}
	}
}
