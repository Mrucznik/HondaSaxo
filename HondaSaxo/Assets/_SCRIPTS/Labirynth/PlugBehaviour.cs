using System.Collections;
using UnityEngine;

public class PlugBehaviour : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 5f;


    // Update is called once per frame
    IEnumerable Update () {
		transform.Translate(Vector3.up * Time.deltaTime * speed);
	    transform.Rotate(Vector3.back, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        if (Time.time % .1f <= 0.01f)
        {
            GameObject gameObject = new GameObject("collider");
            Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
            rb.gravityScale = 0;
            gameObject.transform.position = transform.position;
            CircleCollider2D col = gameObject.AddComponent<CircleCollider2D>();
            col.enabled = false;
            coroutine = enableCollider(col);
            StartCoroutine(coroutine);
            col.radius = 0.06f;
            gameObject.transform.tag = "Player";
        }
    }

    IEnumerable enableCollider(CircleCollider2D col)
    {
        col.enabled = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            LabirynthManager labirynthManager =
                GameObject.Find("LabirynthManager").gameObject.GetComponent<LabirynthManager>();

            labirynthManager.loseLife();
        }
    }
}
