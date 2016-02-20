using UnityEngine;
using System.Collections;

public class ManAnimation : MonoBehaviour {
	private Animator anim;
	private GameController gc;
	private MeshRenderer[] rends;
	private MeshRenderer parachuteRenderer = null;
	public string animationState;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> (); 
		anim.SetBool ("jump", true);
		gc = (GameController) FindObjectOfType(typeof(GameController));
		rends = gameObject.GetComponentsInChildren<MeshRenderer>();
	}

	// Update is called once per frame
	void Update () {
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
