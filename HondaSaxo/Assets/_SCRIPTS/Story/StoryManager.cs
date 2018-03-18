using System;
using System.Collections.Generic;
using Assets._SCRIPTS.Story;
using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    private static StoryManager _instance;
    
    public Quest ActiveQuest;

    public GameObject JegoMordaPanel;
    public GameObject JegoMordaText;
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
        QuestFactory questFactory = new QuestFactory();
        ActiveQuest = questFactory.GetQuests();
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
