using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlugBehaviour : MonoBehaviour
{

    public float speed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.up * Time.deltaTime * speed);
	    transform.Rotate(Vector3.back, Input.GetAxis("Horizontal")); ;

    }
}
