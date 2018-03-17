using System.Collections;
using System.Collections.Generic;
using Assets._SCRIPTS.Story;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    /*
     * Co powinno zawierać tworzenie fabuły
     * - Tworzenie postaci
     * - Wpływ gry na reakcje postaci
     * - Questy
     */
    private static StoryManager _instance;

    private List<Quest> _quests;
    private Quest _activeQuest;

    public GameObject JegoMordaPanel;
    public GameObject MojaMordaPanel;
    public GameObject TextPanel;
    public Canvas Canvas;

    public Text[] OptionText = new Text[3];
    public Text Text;

    public bool Active
    {
        get { return Canvas.gameObject.activeSelf; }
        set { Canvas.gameObject.SetActive(value); }
    }

    private StoryManager()
    {
        _quests = new List<Quest>();
    }
    void Start()
    {
        var testQuest = new Quest();
        DialogSequence dialogSequence = new DialogSequence(Text, OptionText);
        
        dialogSequence.AddDialog(new DialogLine("Siema pl"));
        dialogSequence.AddDialog(new DialogLine("Elo"));
        dialogSequence.AddDialog(new DialogChoice("Luj na morde", "Lepa na twarz", "Dynia w klate"));

        testQuest.AddDialogSequence(dialogSequence);
        _quests.Add(testQuest);

    }

    void Update()
    {
        if (Active)
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                bool questAvaible = _quests[0].DisplayNextSequence();
                if (!questAvaible)
                {
                    Active = false;
                }
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {

            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {

            }
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public static StoryManager GetInstance()
    {
        if (_instance == null)
        {
            return new StoryManager();
        }

        return _instance;
    }
}
