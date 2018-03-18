using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : SingletonMonoBehaviour<Player>
{

    [SerializeField]
    public float speed, Jumpforce;
	[SerializeField]
	public bool InWater,ablePump,ableDrainge;
	private const int MAX_JUMP_COUNT = 2;
	private int jumpCount = 0;
    Rigidbody2D rb2D;
    ChangeTemp changeTemp;
	public bool Jumpable,Leftable,Rightable;
    float resis = 1;

    // Use this for initialization
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Jumpable: " + Jumpable);
        //ChangeTempのAirTemp（温度）の2分の１の力で移動
        //speed = GetComponent<ChangeTemp> ().AirTemp / 2;
        //ChangeTempのAirTemp（温度）の8倍の力でジャンプ
        //Jumpforce = GetComponent<ChangeTemp> ().AirTemp * 8f;

    }
    public void GoLeft()
    { //左にいく時の挙動
            //Debug.Log("キャラクターが左に進んでいます");
            rb2D.velocity = new Vector2(-speed, rb2D.velocity.y);
		if (rb2D.velocity.x > 0) {
			rb2D.velocity = new Vector2 (Mathf.Clamp (rb2D.velocity.x - resis, 3, 100), rb2D.velocity.y);
		}
        //キャラクターの向きを左に向ける
        gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    public void GoRight()
    { //右にいく時の挙動
            rb2D.velocity = new Vector2(speed, rb2D.velocity.y);
		if (rb2D.velocity.x < 0) {
			rb2D.velocity = new Vector2 (Mathf.Clamp (rb2D.velocity.x + resis, -100, -3), rb2D.velocity.y);
		}
        //キャラクターの向きを右に向ける
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void Jump()
    { //ジャンプの挙動
      //プレイヤーが着地した時にジャンプできる
		if (jumpCount < MAX_JUMP_COUNT)
        {
			Jumpable = true;
            rb2D.AddForce(new Vector2(rb2D.velocity.x, Jumpforce));
            //Debug.Log("キャラクターがジャンプしています");
        }

    }
	void FixedUpdate() 
	{ 
		if( Jumpable ) 
		{ 
			// 速度をクリアした2回目のジャンプも1回目と同じ挙動にする。 
			rb2D.velocity = Vector2.zero; 

			// ジャンプさせる。 
			rb2D.AddForce( Vector2.up * Jumpforce ); 

			// ジャンプ回数をカウント。 
			jumpCount++; 

			// ジャンプを許可する。 
			Jumpable = false; 
		} 
	} 


	public void Pump(){
		ablePump = true;
		ableDrainge = true;
	}
	public void Drainage(){
		ableDrainge = false;
	}

    //Stageのタグのついた場所に着地した時にジャンプ可能にする
    void OnCollisionEnter2D(Collision2D thing)
    {
		if (thing.gameObject.tag == "Stage") {
			jumpCount = 0;
		}
	}
	void OnTriggerStay2D(Collider2D thing)
	{
		if (thing.gameObject.tag == "Water" && ablePump == true) {
			InWater = true;
			Debug.Log ("Inwater");

		}
		if (InWater == true && ableDrainge == false && thing.gameObject.tag == "EmptyBox") {
			InWater = false;
			EmptyBox.Instance.WaterEmpty = true;
			Debug.Log (" " + EmptyBox.Instance.WaterEmpty);
		}
	}
}
