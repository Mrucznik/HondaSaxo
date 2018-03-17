using System.Collections;
using System.Collections.Generic;
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
        if (lifes == 0)
        {
            Debug.Log("Dieded!");
        }
    }

    public void loseLife()
    {
        lifes--;
        Destroy(player);

        player = Instantiate(playerPrefab, GameObject.Find("Spawn Point").transform);
    }
}
