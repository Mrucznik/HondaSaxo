using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._SCRIPTS.Story
{
    public class DialogChoice : IDialog
    {
        private List<DialogLine> _choices;
        private List<IDialog> lol;

        public DialogChoice()
        {
            this._choices = new List<DialogLine>();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
