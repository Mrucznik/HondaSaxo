using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MpcScripts : MonoBehaviour {
    public string Name;
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StoryManager.GetInstance().ActiveQuest.StartCharacterSequence(Name);
    }
}
