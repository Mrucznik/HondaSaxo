using System.Collections;
using UnityEngine;

public class LabirynthManager : MonoBehaviour
{
    private int lifes = 3;
    public GameObject playerPrefab;
    private GameObject player;
    private Vector2 spawnPoint;
    void Start()
    {
        player = Instantiate(playerPrefab, GameObject.Find("Spawn Point").transform);
    }


    void Update()
    {
        
    }

    public void loseLife()
    {
        lifes--;
        Destroy(player);
        if (lifes >= 0)
        {
            StartCoroutine(newPlayer());
        }
        else if (lifes < 0)
        {
            Debug.Log("No more lifes!");
        }
    }

    IEnumerator newPlayer()
    {
        yield return new WaitForSeconds(2f);
        Destroy(player);
        player = Instantiate(playerPrefab, GameObject.Find("Spawn Point").transform);
    }
}
