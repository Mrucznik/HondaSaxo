using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MpcScripts : MonoBehaviour {
    public string Name;

    private bool collisionOccured = false;

	void OnTriggerEnter2D (Collider2D col)
	{
	    StoryManager.GetInstance().ActiveQuest.StartCharacterSequence(Name);
    }
}
