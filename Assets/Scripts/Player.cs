using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	
	[SerializeField]
	public float speed,Jumpforce; 
	Rigidbody2D rb2D;
	ChangeTemp changeTemp;
	public bool Jumpable = true;

	// Use this for initialization
	void Start () {
		rb2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update(){
		Debug.Log ("Jumpable: " + Jumpable);
		//ChangeTempのAirTemp（温度）の2分の１の力で移動
		speed = GetComponent<ChangeTemp> ().AirTemp / 2;
		//ChangeTempのAirTemp（温度）の8倍の力でジャンプ
		Jumpforce = GetComponent<ChangeTemp> ().AirTemp * 8f;
			
	}
	public void GoLeft(){ //左にいく時の挙動
		if (Jumpable == true) {
			Debug.Log ("キャラクターが左に進んでいます");
			rb2D.velocity = new Vector2 (-speed, rb2D.velocity.y);
			//キャラクターの向きを左に向ける
			gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
		} else {
			rb2D.velocity = new Vector2 (-speed /1.3f, rb2D.velocity.y);
			gameObject.transform.rotation = Quaternion.Euler (0, 180, 0);
		}
	}

	public void GoRight(){ //右にいく時の挙動
		if (Jumpable == true) {
			Debug.Log ("キャラクターが右に進んでいます");
			rb2D.velocity = new Vector2 (speed, rb2D.velocity.y);
			//キャラクターの向きを右に向ける
			gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
		} else {
			rb2D.velocity = new Vector2 (speed /1.3f, rb2D.velocity.y);
			//キャラクターの向きを右に向ける
			gameObject.transform.rotation = Quaternion.Euler (0, 0, 0);
		}
	}

	public void Jump(){ //ジャンプの挙動
		//プレイヤーが着地した時にジャンプできる
		if (Jumpable == true) {
			rb2D.AddForce (new Vector2 (rb2D.velocity.x, Jumpforce));
			Debug.Log ("キャラクターがジャンプしています");
		}

	}

	//Stageのタグのついた場所に着地した時にジャンプ可能にする
	void OnCollisionEnter2D(Collision2D thing){
		//if (thing.gameObject.tag == "Stage") {
			Jumpable = true;
			Debug.Log ("hoge");
		//}
	}
	//Stageのタグのついた場所からジャンプしたらジャンプ不能になる
	void OnCollisionExit2D(Collision2D thing){
		//if (thing.gameObject.tag == "Stage") {
			Jumpable = false;
			Debug.Log ("hoge");
		//}
	}
}