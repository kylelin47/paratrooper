using UnityEngine;
using System.Collections;

public class HoleSize : MonoBehaviour {
    public Renderer rend;
    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        float radius = rend.bounds.extents.x;
        print(radius);
    }
	
	// Update is called once per frame
	void Update () {
	}
}
