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

    public GameObject MordaPanel;
    public GameObject TextPanel;
    public Canvas Canvas;

    public Text[] OptionText = new Text[3];
    public Text Text;

    private StoryManager()
    {
        _quests = new List<Quest>();
    }
    void Start()
    {
        var testQuest = new Quest();
        testQuest.AddDialogSequence(new DialogSequence(TextPanel));
        _quests.Add(testQuest);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            _quests[0].DisplayNextSequence();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {

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
