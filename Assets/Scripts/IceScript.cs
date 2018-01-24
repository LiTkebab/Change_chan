using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceScript : MonoBehaviour {

    ChangeTemp changeTemp = new ChangeTemp();
    public Animator animator;
    [SerializeField]
    public float TowaterTemp;


    // Use this for initialization
    void Start()
    {
        TowaterTemp = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        //animator = GetComponent<Animator>();
        if (changeTemp.AirTemp > 25 || Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("change_state", true);
            Debug.Log("towater");
        }

    }
}

