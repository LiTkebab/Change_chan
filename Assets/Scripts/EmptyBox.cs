using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyBox : MonoBehaviour {
	public GameObject Water;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void InWater(){
	
	}

	void OnTriggerEnter2D(Collider2D player){
		
		if (Player.Instance.InWater == true) {
			
		}

	}
}
