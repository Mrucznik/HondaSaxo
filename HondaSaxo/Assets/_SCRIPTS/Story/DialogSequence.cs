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

        public DialogSequence()
        {
            _dialogs = new Queue<IDialog>();
        }

        public void AddDialogLine(DialogLine dialogLine)
        {
            _dialogs.Enqueue(dialogLine);
        }

        public void AddDialogChoice(DialogChoice dialogChoice)
        {
            _dialogs.Enqueue(dialogChoice);
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.KeypadEnter))
            {
                _activeDialog = _dialogs.Dequeue();
                _activeDialog.Display(new Vector2(0, 0));
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {

            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {

            }
        }
    }
}
