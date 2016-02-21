using UnityEngine;
using System.Collections;

public class AttachToPlayer : MonoBehaviour {
	private GameObject player;
	private ManAnimation ma;
	private bool playerVisible;
	// Use this for initialization
	void Start () {
		playerVisible = true;
		player = GameObject.FindWithTag ("Player");
		ma = (ManAnimation) FindObjectOfType(typeof(ManAnimation));
	}
	private void setPlayer(bool visible) {
		if (playerVisible != visible) {
			ma.SetRenderEnable (visible);
			playerVisible = visible;
		}
	}
	void LateUpdate () {
		if (ma.animationState == "beginSpread" || ma.animationState == "beginStand") {
			transform.parent = player.transform;
			setPlayer (false);
		} else {
			transform.parent = null;
			transform.position = player.transform.position;
			setPlayer (true);
		}
	}
}
