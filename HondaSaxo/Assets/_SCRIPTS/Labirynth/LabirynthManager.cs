using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabirynthManager : MonoBehaviour
{
    private int lifes = 3;

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
    }
}
