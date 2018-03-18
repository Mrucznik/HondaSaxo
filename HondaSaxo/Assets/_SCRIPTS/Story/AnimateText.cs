using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class AnimateText : MonoBehaviour
{

    public static AnimateText _instance;
    
    private string _text;
    private Coroutine _currentCoroutine, _lastCoroutine = null;
    private AnimateText()
    {
    }

    void Start()
    {
        _instance = this;
    }

    public void Display(Text obj, string text)
    {
        _lastCoroutine = _currentCoroutine;
        _currentCoroutine = StartCoroutine(Animate(obj, text));
        _text = text;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return) && _lastCoroutine != null)
        {
            StopCoroutine(_lastCoroutine);
            Debug.Log("Stopuje lastCoroutine " + _lastCoroutine);
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
