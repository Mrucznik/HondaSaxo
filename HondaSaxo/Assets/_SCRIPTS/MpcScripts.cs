using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MpcScripts : MonoBehaviour {
    public string Name;

    private bool collisionOccured = false;

	void OnTriggerStay2D (Collider2D col)
	{
        Debug.Log("Trigger");
        if(Input.GetKey(KeyCode.Return))
	    StoryManager.GetInstance().ActiveQuest.StartCharacterSequence(Name);
    }
}
