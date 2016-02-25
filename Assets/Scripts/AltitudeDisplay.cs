using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AltitudeDisplay : MonoBehaviour {
	private Text altitude;
	private GameController gc;

	// Use this for initialization
	void Start () {
		gc = (GameController) FindObjectOfType(typeof(GameController));
		altitude = GetComponent<Text> ();
		StartCoroutine("Altimeter");
	}
	private IEnumerator Altimeter() {
		while (true) {
			if (gc.playerActive) {
				altitude.text = "Altitude: " + (gc.playerAltitude * 3.28).ToString ("F") + " ft";
			}
			yield return new WaitForSeconds (0.5f);
		}
	}
}
