using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._SCRIPTS.Story
{
    public class Quest
    {
        private List<DialogSequence> _dialogSequences;

        public Quest()
        {
            _dialogSequences = new List<DialogSequence>();
        }

        public void AddDialogSequence(DialogSequence dialog)
        {
            _dialogSequences.Add(dialog);
        }

        public void DisplayNextSequence()
        {
            _dialogSequences[0].Display();
        }
    }
}
