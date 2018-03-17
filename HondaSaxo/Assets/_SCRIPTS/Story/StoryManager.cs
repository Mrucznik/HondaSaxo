using System.Collections;
using System.Collections.Generic;
using Assets._SCRIPTS.Story;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    /*
     * Co powinno zawierać tworzenie fabuły
     * - Tworzenie postaci
     * - Wpływ gry na reakcje postaci
     * - Questy
     */

    private List<Quest> _quests; 
    
	void Start ()
	{
	    _quests = new List<Quest>();
	}
	
	void Update ()
	{
		
	}
}
