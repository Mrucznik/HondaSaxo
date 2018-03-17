using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._SCRIPTS.Story
{
    public class DialogSequence : MonoBehaviour
    {
        private readonly Queue<IDialog> _dialogs;
        private IDialog _activeDialog;
        private GameObject _canvas;
        private float x = 0;

        public DialogSequence()
        {
            _dialogs = new Queue<IDialog>();

            AddDialogLine(new DialogLine("Siema pl"));
            AddDialogLine(new DialogLine("Elo"));
        }

        void Start()
        {
            _canvas = new GameObject("DialogSequenceCanvas");
            _canvas.AddComponent<Canvas>();
            Canvas myCanvas = _canvas.GetComponent<Canvas>();
            myCanvas.transform.localScale = new Vector3(1, .5f, 1);
        }

        public void AddDialogLine(DialogLine dialogLine)
        {
            _dialogs.Enqueue(dialogLine);
        }

        /*public void AddDialogChoice(DialogChoice dialogChoice)
        {
            _dialogs.Enqueue(dialogChoice);
        }*/

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                _activeDialog = _dialogs.Dequeue();
                _activeDialog.Display(_canvas, new Vector2(0, x));
                x += 20;
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {

            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {

            }
        }
    }
}
