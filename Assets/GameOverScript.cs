﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnColisionEnter(Collision col)
    {
        if (gameObject.CompareTag("Player"))
        {
           
        }

    }
}