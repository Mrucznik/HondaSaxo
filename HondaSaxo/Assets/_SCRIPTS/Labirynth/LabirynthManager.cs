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
        if (lifes > 0)
        {
            player = Instantiate(playerPrefab, GameObject.Find("Spawn Point").transform);
        }
        else if (lifes <= 0)
        {
            Debug.Log("Dieded!");
        }
    }
}
