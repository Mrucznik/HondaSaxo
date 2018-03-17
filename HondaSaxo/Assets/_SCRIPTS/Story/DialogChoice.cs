using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public class DialogChoice : IDialog
    {
        private readonly string[] _choices = new string[3];
        private int activeChoice = 0;

        public DialogChoice(string choice1, string choice2, string choice3)
        {
            _choices[0] = choice1;
            _choices[1] = choice2;
            _choices[2] = choice3;
        }

        public void Display(Text[] texts)
        {
            for(int i=0; i<_choices.Length; i++)
            {
                texts[i].text = _choices[i];
            }

            HighlightActiveOption(texts);
        }

        public void SetActiveOption(int option)
        {
            activeChoice = option;
        }

        public void HighlightActiveOption(Text[] texts)
        {
            for (int i = 0; i < texts.Length; i++)
            {
                texts[activeChoice].color = Color.black;
            }
            texts[activeChoice].color = Color.green;
        }
    }
}
