using UnityEngine;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public class DialogChoice : IDialog
    {
        private readonly IDialog[] _nextDialog = new IDialog[3];
        private readonly string[] _choices = new string[3];
        private readonly string _title;
        private readonly Character _character;
        private int _activeChoice = 0;

        public DialogChoice(string title, Character character, string choice1, IDialog nextDialog1, string choice2, IDialog nextDialog2, string choice3, IDialog nextDialog3)
        {
            _title = title;
            _character = character;
            _nextDialog[0] = nextDialog1;
            _nextDialog[1] = nextDialog2;
            _nextDialog[2] = nextDialog3;
            _choices[0] = choice1;
            _choices[1] = choice2;
            _choices[2] = choice3;
        }

        public void NextActiveOption()
        {
            _activeChoice = (_activeChoice - 1 < 0) ? (_choices.Length - 1) : (_activeChoice - 1);
            HighlightActiveOption();
        }

        public void PreviousActiveOption()
        {
            _activeChoice = (_activeChoice + 1) % _choices.Length;
            HighlightActiveOption();
        }

        public void HighlightActiveOption()
        {
            foreach (var t in StoryManager.GetInstance().OptionText)
            {
                t.color = Color.white;
            }
            StoryManager.GetInstance().OptionText[_activeChoice].color = Color.green;
        }

        public void Display()
        {
            StoryManager.GetInstance().Text.text = _title;
            for (int i = 0; i < _choices.Length; i++)
            {
                StoryManager.GetInstance().OptionText[i].text = "- " + _choices[i];
            }
            HighlightActiveOption();
            _character.WyswietlMorde();
        }

        public IDialog GetNextDialog()
        {
            return _nextDialog[_activeChoice];
        }
    }
}
