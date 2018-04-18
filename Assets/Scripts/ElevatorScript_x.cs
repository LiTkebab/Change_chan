using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ElevatorScript_x : PushedButtonScript
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
            transform.DOMove(new Vector3(transform.position.x + 90, transform.position.y, transform.position.z), 6);
            yield return new WaitForSeconds(5.0f);
            transform.DOMove(new Vector3(transform.position.x - 90, transform.position.y, transform.position.z), 6);
            yield return new WaitForSeconds(5.0f);
        }
    }
}