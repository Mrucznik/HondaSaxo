using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Experimental.UIElements;

namespace Assets._SCRIPTS.Story
{
    class Choice
    {
        private string _text;
        private Button _button;

        public Choice(string text, Button button)
        {
            this._text = text;
            this._button = button;

        }
    }
}
