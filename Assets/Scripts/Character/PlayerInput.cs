using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput: MonoBehaviour {
	
	Player player;
	ChangeTemp changeTemp;
	public Animator animator;

	// Use this for initialization
	void Start () {
		player = GetComponent<Player> ();
		changeTemp = GetComponent<ChangeTemp> ();
		
	}
	
	// Update is called once per frame
	void Update(){
		
		//プレイヤーの操作     GetAxisを使う？？？
		if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
		{
			//Aと←でプレイヤーを左に移動させる
			player.GoLeft();

		}
		if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
		{
			//Dと→でプレイヤーを左に移動させる
			player.GoRight();
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			//スペースバーでプレイヤーをジャンプさせる
			player.Jump();
		}

		if (Input.GetKeyDown(KeyCode.Q)) {
			//Qキーで水を汲む
			player.Pump ();
		}
		if (Input.GetKeyDown(KeyCode.E)) {
			//Eキーで水を放水
			player.Drainage ();
		}
		//温度変化
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
		{
			//Wと↑で温度を上昇させる
			changeTemp.UpTemp();

		}
		if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
		{
			//Sと↓で温度を降下させる
			changeTemp.DownTemp();

		}

	}

}
