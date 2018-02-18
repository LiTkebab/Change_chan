using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    public bool Buttonable = true;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D thing)
    {
        if (thing.gameObject.tag == "Stage")
        {
            Buttonable = true;
        }
    }
}
