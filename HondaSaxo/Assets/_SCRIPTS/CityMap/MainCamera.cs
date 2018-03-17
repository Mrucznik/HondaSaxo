using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Vuforia;

public class MainCamera : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update () {

        if (Vector2.Distance(player.transform.position, transform.position) > 4)
        {
            Debug.Log(Vector2.Distance(player.transform.position, transform.position));
            transform.position = Vector2.Lerp(transform.position, player.transform.position, Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
    }
}
