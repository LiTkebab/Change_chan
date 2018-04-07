using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript :SingletonMonoBehaviour<FireScript> {
	[SerializeField]
	public bool DeleteFire;
	[SerializeField]
	public GameObject FireObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (DeleteFire == true) {
			StartCoroutine ("DeleteFirePassage");  
		}
	}


	private IEnumerator DeleteFirePassage() {
		yield return new WaitForSeconds (0.1f); 
		FireObj.transform.localScale = new Vector3(0.5f, 1,1);
		yield return new WaitForSeconds (0.1f); 
		FireObj.transform.localScale = new Vector3(0.25f,0.25f,1f);
		yield return new WaitForSeconds (0.1f); 
		FireObj.SetActive (false);
	}

}
