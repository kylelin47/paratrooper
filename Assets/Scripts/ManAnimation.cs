using UnityEngine;
using System.Collections;

public class ManAnimation : MonoBehaviour {
	private Animator anim;
	private GameController gc;
	private MeshRenderer[] rends;
	private MeshRenderer parachuteRenderer = null;
	public string animationState;
	private GameObject door;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> (); 
		gc = (GameController) FindObjectOfType(typeof(GameController));
		rends = gameObject.GetComponentsInChildren<MeshRenderer>();
		door = GameObject.FindWithTag ("Door");
	}

	// Update is called once per frame
	void Update () {
		//if (gc.playerActive) {
		//	anim.SetBool ("jump", true);
		//}
		if (gc.SkydiveKey () && door.transform.eulerAngles.y == 270) {
			anim.SetBool ("jump", true);
		}
		if (gc.parachuteActive) {
			anim.SetTrigger ("parachute");
		}
	}

	private void NotifyAnimationState(string state) {
		animationState = state;
	}

	public void SetRenderEnable(bool enabled) {
		foreach (MeshRenderer m in rends) {
			m.enabled = enabled;
		}
		if (gc.parachuteActive && parachuteRenderer == null) {
			parachuteRenderer = GameObject.FindWithTag ("Parachute").GetComponent<MeshRenderer> ();
		}
		if (parachuteRenderer != null) {
			parachuteRenderer.enabled = enabled;
		}
	}
}
