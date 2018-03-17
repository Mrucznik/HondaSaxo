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
        public string Text { get; private set; }

        public DialogLine(string text)
        {
            Text = text;
        }

        public void Display(Text text)
        {
            text.text = Text;
        }
    }
}
