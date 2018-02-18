using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    [SerializeField] PushedButtonScript gimmick;

    void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player")
        {
            gimmick.OnButtonPushed();
        }
    }
}
