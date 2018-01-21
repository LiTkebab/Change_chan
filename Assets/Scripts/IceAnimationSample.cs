using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceAnimationSample : MonoBehaviour
{

    public Animator animator;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //animator = GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("change_state", true);
        }
    }
}

