using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTemp : MonoBehaviour {
	public float AirTemp;
	public 
	// Use this for initialization
	void Start () {
		AirTemp = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("現在の温度：" + AirTemp);


	}
	public void UpTemp(){
		if (AirTemp < 100) {
			AirTemp += 0.5f;
		}
	}
	public void DownTemp(){
		if (AirTemp > 0) {
			AirTemp -= 0.5f;
		}
	}
}
