using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ElevatorScript : PushedButtonScript
{
    Rigidbody2D rb2D;
    [SerializeField]
    RectTransform rectTran;


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {         
    }

    public override void OnButtonPushed()
    {
        StartCoroutine("Elve");
       

    }

    private IEnumerator Elve()
    {
        while (true)
        {
            transform.DOMove(new Vector3(transform.position.x, transform.position.y +40, transform.position.z), 4);
            yield return new WaitForSeconds(5.0f);
            transform.DOMove(new Vector3(transform.position.x, transform.position.y -40, transform.position.z), 4);
            yield return new WaitForSeconds(5.0f);
        }
    }
}