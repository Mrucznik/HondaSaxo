using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityMapBehaviour : MonoBehaviour {
    public float speed = 5f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

       /* transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        transform.Translate(Vector3.left * Time.deltaTime, Space.World);
        transform.Translate(Vector3.right * Time.deltaTime, Space.World);*/
    }
}
