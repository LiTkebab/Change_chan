using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_stage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionStay2D( Collision2D other )

	{
		if (Player.Instance.InWater == true) {
			gameObject.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.None; 
		}
	}

}
