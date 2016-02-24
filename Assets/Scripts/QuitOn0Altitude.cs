using UnityEngine;
using System.Collections;

public class QuitOn0Altitude : MonoBehaviour {
    private GameController gc;
    // Use this for initialization
    void Start () {
        gc = (GameController)FindObjectOfType(typeof(GameController));
    }
	
	// Update is called once per frame
	void Update () {
        if((gc.playerAltitude * 3.28) < 0  )
        {
            print("Game has quit technically");
            Application.Quit(); //quit game when altitude is 0
        }
	}
}
