using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Assets._SCRIPTS.Story
{
    public class Choice : IDialog
    {
        private string _text;
        private Button _button;
        private readonly IDialog _dialogOption;

        public Choice(string text, IDialog dialogOption)
        {
            this._text = text;
            _dialogOption = dialogOption;
            this._button = new Button(ClickEvent);
        }

        private void ClickEvent()
        {
            _dialogOption.Display(Vector2.zero);
        }

        public void Display(Vector2 position)
        {
            throw new NotImplementedException();
        }
    }
}
