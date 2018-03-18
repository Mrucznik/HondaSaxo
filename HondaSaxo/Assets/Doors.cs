using System.Collections;
using System.Collections.Generic;
using Assets._SCRIPTS.Story;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    public string name;
    public int sceneID;

    private DialogSequence DS;
    
	void Start ()
	{
	    DS = new DialogSequence(new DialogChoice("Czy napewno chcesz wejść do " + name, new Character("Door", false), "Tak", new DoorDialog(sceneID), "Nie", null));
	}

    void OnTriggerStay2D(Collider2D col)
    {
        Debug.Log("Trigger");
        if (Input.GetKey(KeyCode.Return))
        {
            DS.StartDialog();
        }
    }
}
