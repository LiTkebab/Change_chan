using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyBox : SingletonMonoBehaviour<EmptyBox> {
	public GameObject Water;
	public bool WaterEmpty;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (WaterEmpty == true) {
			Instantiate (Water,gameObject.transform.position, Quaternion.identity);
			WaterEmpty = false;
		}
	}
}
