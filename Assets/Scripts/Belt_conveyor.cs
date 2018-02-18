using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt_conveyor : MonoBehaviour {
	
	[SerializeField]
	public float   m_movePower = 50.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionStay2D( Collision2D other )
		
	{
		other.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (-m_movePower,other.gameObject.GetComponent<Rigidbody2D>().velocity.y);

	}

}
