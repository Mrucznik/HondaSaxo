using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._SCRIPTS.Story
{
    public class DialogSequence : IDialog
    {
        private Queue<IDialog> _dialogs;

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

        public void Talk()
        {
            _dialogs.Dequeue();
        }

        public void Display(Vector2 position)
        {

        }
    }
}
