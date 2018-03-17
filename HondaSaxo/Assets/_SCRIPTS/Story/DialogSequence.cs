using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public class DialogSequence
    {
        private readonly Queue<IDialog> _dialogs;
        private IDialog _activeDialog;
        private readonly Text _textPanel;
        private readonly Text[] _choicePanel;

        public DialogSequence(Text textPanel, Text[] choicePanel)
        {
            _dialogs = new Queue<IDialog>();
            _textPanel = textPanel;
            _choicePanel = choicePanel;
        }

        public void AddDialog(IDialog dialogLine)
        {
            _dialogs.Enqueue(dialogLine);
        }

        public bool Display()
        {
            if (_dialogs.Count <= 0)
            {
                return false;
            }
            _activeDialog = _dialogs.Dequeue();

            ClearTextPanels();

            var dialogLine = _activeDialog as DialogLine;
            if (dialogLine != null)
            {
                dialogLine.Display(_textPanel);
                return true;
            }

            var dialogChoice = _activeDialog as DialogChoice;
            if (dialogChoice != null)
            {
                dialogChoice.Display(_choicePanel);
                return true;
            }
            return true;
        }

        public void ClearTextPanels()
        {
            _textPanel.text = "";
            foreach (var choice in _choicePanel)
            {
                choice.text = "";
            }
        }
    }
}
