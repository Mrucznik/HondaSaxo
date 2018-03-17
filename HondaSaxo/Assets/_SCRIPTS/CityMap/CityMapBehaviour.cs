using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityMapBehaviour : MonoBehaviour {
    public float speed = 5f;

    private Animator animator;
	// Use this for initialization
	void Start ()
	{
	    animator = GetComponent<Animator>();
	}


    // Update is called once per frame
    void Update ()
    {

        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);

        if(Input.GetAxis("Vertical") > 0)
        animator.SetInteger("state", 1);
        else if(Input.GetAxis("Vertical") < 0)
        animator.SetInteger("state", 2);
        else if(Input.GetAxis("Horizontal") > 0)
        animator.SetInteger("state", 3);
        else if(Input.GetAxis("Horizontal") < 0)
        animator.SetInteger("state", 4);
        else
        animator.SetInteger("state", 0);
        
        
    }
}
