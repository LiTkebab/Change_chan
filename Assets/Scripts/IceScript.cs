using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceScript : MonoBehaviour {

    //ChangeTemp changeTemp;
    public Animator animator;
    [SerializeField]
   	float TowaterTemp;


    // Use this for initialization
    void Start()
    {
        TowaterTemp = 25f;

		
    }

    // Update is called once per frame
    void Update()
    {
        //animator = GetComponent<Animator>();
			
		
		if (ChangeTemp.Instance.AirTemp > TowaterTemp)
        {
            animator.SetBool("change_state", true);
			StartCoroutine ("Towater");  
        }
		if (ChangeTemp.Instance.AirTemp < TowaterTemp)
		{
			animator.SetBool("change_state", false);
			StartCoroutine ("ToIce");  
		}




    }

	private IEnumerator Towater() {
		
		//1秒後に氷のコライダーがなくなる
		yield return new WaitForSeconds (0.6f); 
		gameObject.GetComponent<BoxCollider2D> ().enabled  = false;
		if (gameObject.tag == "IceD") {
			Destroy (gameObject);
		}

	} 
	private IEnumerator ToIce() {  
		//1秒後に氷のコライダーがなくなる
		yield return new WaitForSeconds (1.0f); 
		gameObject.GetComponent<BoxCollider2D> ().enabled  = true;
	} 
}

