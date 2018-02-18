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
        if (Input.GetKey(KeyCode.K))
        {
            StartCoroutine("Elve");
        }
        
    }

    public override void OnButtonPushed()
    {
        StartCoroutine("Elve");
       

    }

    private IEnumerator Elve()
    {
        // 1秒待つ  
       // yield return new WaitForSeconds(1.0f);

        // ログ出力  
        transform.DOMove(new Vector3(transform.position.x, transform.position.y + 40, transform.position.z), 4);

        // 2秒待つ  
        yield return new WaitForSeconds(5.0f);

        // ログ出力  
        transform.DOMove(new Vector3(transform.position.x, transform.position.y - 40, transform.position.z), 4);

        yield return new WaitForSeconds(5.0f);

        // ログ出力  
        transform.DOMove(new Vector3(transform.position.x, transform.position.y + 40, transform.position.z), 4);

        yield return new WaitForSeconds(5.0f);
        // ログ出力  
        transform.DOMove(new Vector3(transform.position.x, transform.position.y - 40, transform.position.z), 4);
        yield return new WaitForSeconds(5.0f);

        // ログ出力  
        transform.DOMove(new Vector3(transform.position.x, transform.position.y + 40, transform.position.z), 4);

        yield return new WaitForSeconds(5.0f);
        // ログ出力  
        transform.DOMove(new Vector3(transform.position.x, transform.position.y - 40, transform.position.z), 4);
    }
}