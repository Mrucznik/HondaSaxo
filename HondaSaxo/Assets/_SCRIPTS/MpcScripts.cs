using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MpcScripts : MonoBehaviour {
    public GameObject wtyczkaTest;
    //public static GameObject Elektrij;
   // public Rigidbody2D = Elektrij.GetComponent<Rigidbody2D>();
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // rb.GetComponent<Rigidbody2D>();
        //rb.constraints= RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        //rb.sleepMode

        wtyczkaTest.SetActive(true);
        Debug.Log("zły dotyk");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        wtyczkaTest.SetActive(false);
        Debug.Log("boli całe życie");
    }
}
