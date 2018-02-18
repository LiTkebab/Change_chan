using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour{

    public float position;
    public float speed;
    Rigidbody2D rb2D;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K))//ここの条件は後でボタンにする
        {
           transform.position += new Vector3(0, speed, 0);
        }
        if (transform.position.y >= position)
        {
            Debug.Log("down");
        }
    }
}