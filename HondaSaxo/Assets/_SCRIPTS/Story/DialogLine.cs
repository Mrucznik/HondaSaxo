using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._SCRIPTS.Story
{
    public class DialogLine : IDialog
    {
        public Character Interlocutor { get; private set; }
        public string Text { get; private set; }

        public DialogLine(Character interlocutor, string text)
        {
            Interlocutor = interlocutor;
            Text = text;
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
