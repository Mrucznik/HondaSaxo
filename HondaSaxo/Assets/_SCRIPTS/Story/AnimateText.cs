using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnimateText : MonoBehaviour
{

    public static AnimateText _instance;
    
    private string _text;
    private Text _obj;
    private Coroutine _currentCoroutine;
    private bool finished = true;
    private AnimateText()
    {
    }

    void Start()
    {
        _instance = this;
    }

    public void Display(Text obj, string text)
    {
        if (_currentCoroutine != null)
        {
            StopCoroutine(_currentCoroutine);
        }

        _currentCoroutine = StartCoroutine(Animate(obj, text));
        _text = text;
        _obj = obj;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StopCoroutine(_currentCoroutine);
            _obj.text = _text;
        }
    }

    IEnumerator Animate(Text obj, string strComplete)
    {
        int i = 0;
        while (i < strComplete.Length)
        {
            obj.text += strComplete[i++];
            yield return new WaitForSeconds(0.05F);
        }

        finished = true;
    }

    public static AnimateText GetInstance()
    {
        return _instance;
    }
    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
