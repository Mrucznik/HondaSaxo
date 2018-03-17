using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlugBehaviour : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 5f;
    private float timeout = 5f;
    private IEnumerator coroutine;

    private ArrayList colliders;

    void Start()
    {
        colliders = new ArrayList();
    }

    // Update is called once per frame
    void Update ()
    {   
        if(timeout > 0) timeout -= Time.deltaTime;
		transform.Translate(Vector3.up * Time.deltaTime * speed);
	    transform.Rotate(Vector3.back, Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);
        if (Time.time % .1f <= 0.01f)
        {
            GameObject gameObject = new GameObject("collider");

            colliders.Add(gameObject);

            Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();

            rb.gravityScale = 0;
            
            gameObject.transform.position = transform.position;

            CircleCollider2D col = gameObject.AddComponent<CircleCollider2D>();
            col.enabled = false;

            col.radius = 0.06f;
            gameObject.transform.tag = "Player";

            coroutine = enableCollider(col);
            StartCoroutine(coroutine);

        }
    }

    IEnumerator enableCollider(CircleCollider2D col)
    {
        yield return new WaitForSeconds(.5f);
        col.enabled = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.transform.tag == "Player" && timeout <= 0)
        {
            timeout = 5f;
            LabirynthManager labirynthManager =
                GameObject.Find("LabirynthManager").gameObject.GetComponent<LabirynthManager>();

            labirynthManager.loseLife();
        }
    }

    void OnDestroy()
    {
        foreach (GameObject col in colliders)
        {
            Destroy(col);
        }
    }
}
