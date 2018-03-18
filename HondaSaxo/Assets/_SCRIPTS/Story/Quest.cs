using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._SCRIPTS.Story
{
    public class Quest
    {
        private static int questCount = 0;
        public int QuestID { get; private set; }
        private readonly Quest _nextQuest;
        private readonly DialogSequence _beginningSequence;
        private readonly DialogSequence _endingSequence;
        private readonly Dictionary<string, DialogSequence> _dialogSequences;

        private DialogSequence _activeDialogSequence;

        public Quest(DialogSequence beginningSequence, DialogSequence endingSequence, Quest nextQuest)
        {
            this._nextQuest = nextQuest;
            this._beginningSequence = beginningSequence;
            this._endingSequence = endingSequence;

            _dialogSequences = new Dictionary<string, DialogSequence>();

            QuestID = questCount++;
        }

        public void AddDialogSequence(string c, DialogSequence dialog)
        {
            _dialogSequences.Add(c, dialog);
        }

        public void StartCharacterSequence(string c)
        {
            _activeDialogSequence = _dialogSequences[c];
            _activeDialogSequence.StartDialog();
        }

        public void BeginQuest()
        {
            _activeDialogSequence = _beginningSequence;
            _beginningSequence.StartDialog();
        }

        public Quest EndQuest()
        {
            _activeDialogSequence = _endingSequence;
            _endingSequence.StartDialog();
            StoryManager.GetInstance().ActiveQuest = _nextQuest;
            return _nextQuest;
        }
    }
}
