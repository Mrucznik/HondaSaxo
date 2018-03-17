using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public class DialogLine : IDialog
    {
        private readonly string _text;
        private readonly IDialog _nextDialog;

        public DialogLine(string text, IDialog nextDialog)
        {
            _text = text;
            this._nextDialog = nextDialog;
        }
        
        public void Display()
        {
            StoryManager.GetInstance().Text.text = _text;
        }

        public IDialog GetNextDialog()
        {
            return _nextDialog;
        }
    }
}
