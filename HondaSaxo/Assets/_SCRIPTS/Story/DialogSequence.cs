using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._SCRIPTS.Story
{
    public class DialogSequence
    {
        private readonly Queue<IDialog> _dialogs;
        private IDialog _activeDialog;
        private readonly GameObject _textPanel;
        private float x = 0;

        public DialogSequence(GameObject textPanel)
        {
            _dialogs = new Queue<IDialog>();
            _textPanel = textPanel;

            AddDialogLine(new DialogLine("Siema pl"));
            AddDialogLine(new DialogLine("Elo"));
        }

        public void AddDialogLine(DialogLine dialogLine)
        {
            _dialogs.Enqueue(dialogLine);
        }

        /*public void AddDialogChoice(DialogChoice dialogChoice)
        {
            _dialogs.Enqueue(dialogChoice);
        }*/

        public void Display()
        {
            _activeDialog = _dialogs.Dequeue();
            _activeDialog.Display(_textPanel, new Vector2(0, x));
        }
    }
}
