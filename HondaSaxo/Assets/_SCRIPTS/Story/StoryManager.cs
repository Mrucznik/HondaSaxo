using System;
using System.Collections;
using System.Collections.Generic;
using Assets._SCRIPTS.Story;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    private static StoryManager _instance;
    
    private Quest _mainQuest;

    public GameObject JegoMordaPanel;
    public GameObject MojaMordaPanel;
    public GameObject TextPanel;
    public Canvas Canvas;

    public Text[] OptionText = new Text[3];
    public Text Text;

    public readonly List<Action> KeyEnterEvents = new List<Action>();
    public readonly List<Action> KeyUpEvents = new List<Action>();
    public readonly List<Action> KeyDownEvents = new List<Action>();

    public bool Active
    {
        get { return Canvas.gameObject.activeSelf; }
        set { Canvas.gameObject.SetActive(value); }
    }

    private StoryManager()
    {
        //Test quest
        DialogLine startLine =
            new DialogLine("Czesc Dimitrii",
                new DialogLine("Spierdalaj",
                    new DialogChoice("Co chcesz zrobic Dimitriemu",
                        "Zajebac lepe", new DialogLine("* Lepa odjebala Dimitriiowi glowe! *", null),
                        "Zasadzic luja z calej epy", new DialogLine("O zesz Ty kurwa!", null),
                        "Wyjebac z dyni", new DialogLine("* Dimitrii implodowal *", null)
                    )
                )
            );

        DialogLine endLine =
            new DialogLine("No i dobrze, ze z dech",
                new DialogLine("No raczej kurwa nie inaczej",
                    new DialogLine("No i kurwa pierwszorzednie mordo, elo", null)));

        DialogSequence beginningSequence = new DialogSequence(startLine);
        DialogSequence endingSequence = new DialogSequence(endLine);

        _mainQuest = new Quest(beginningSequence, endingSequence, null);
    }

    void Start()
    {
        _instance = this;
        Active = false;

    }

    void Update()
    {
        if (Active)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                foreach (var keyEnter in KeyEnterEvents.ToArray())
                {
                    keyEnter();
                }
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                foreach (var keyUpEvent in KeyUpEvents.ToArray())
                {
                    keyUpEvent();
                }
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                foreach (var keyDownEvent in KeyDownEvents.ToArray())
                {
                    keyDownEvent();
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                _mainQuest.BeginQuest();
            }
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public static StoryManager GetInstance()
    {
        return _instance;
    }
}
