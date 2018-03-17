using System.Collections;
using UnityEngine;

public class PlugBehaviour : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 5f;

    IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(.1f);
        print("WaitAndPrint " + Time.time);
    }

    IEnumerator Start()
    {
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine
        yield return StartCoroutine("WaitAndPrint");
        print("Done " + Time.time);
    }

    // Update is called once per frame
    void Update () {
		transform.Translate(Vector3.up * Time.deltaTime * speed);
	    transform.Rotate(Vector3.back, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
    }

    void OnCollisionDetect(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            LabirynthManager labirynthManager =
                GameObject.Find("LabirynthManager").gameObject.GetComponent<LabirynthManager>();

            labirynthManager.loseLife();
        }
    }
}
