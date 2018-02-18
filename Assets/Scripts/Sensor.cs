using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour {
	private GameObject _parent;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionStay2D(Collision2D thing)
	{
		if (thing.gameObject.tag == "ice") {
			//Destroy (this.gameObject.transform.root.gameObject);
			_parent = transform.root.gameObject;

			Debug.Log ("Parent:" + _parent.name);

		}
	}
}
