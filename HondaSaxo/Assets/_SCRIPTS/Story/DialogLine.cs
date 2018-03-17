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
        private readonly Character _character;

        public DialogLine(string text, Character character, IDialog nextDialog)
        {
            _text = text;
            _nextDialog = nextDialog;
            _character = character;
        }
        
        public void Display()
        {
            StoryManager.GetInstance().Text.text = _text;
            _character.WyswietlMorde();
        }

        public IDialog GetNextDialog()
        {
            return _nextDialog;
        }
    }
}
