using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public class Character
    {
        private string _name;
        private readonly bool _mojaMorda;

        public Character(string name, bool mojaMorda)
        {
            _name = name;
            _mojaMorda = mojaMorda;
        }

        public void WyswietlMorde()
        {
            if (_mojaMorda)
            {
                StoryManager.GetInstance().JegoMordaPanel.SetActive(false);
                StoryManager.GetInstance().MojaMordaPanel.SetActive(true);
            }
            else
            {
                StoryManager.GetInstance().JegoMordaPanel.GetComponent<AvatarDisplayer>().Display(_name);
                StoryManager.GetInstance().MojaMordaPanel.SetActive(false);
                StoryManager.GetInstance().JegoMordaPanel.SetActive(true);
            }
        }
    }
}
